using System;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

const string code = @"
using System;
using System.Collections.Generic;

class Demo
{
    static void Main()
    {
        var list = new List<int> { 1, 2, 3 };
        foreach (var x in list)
        {
            Console.WriteLine(x.ToString());
        }
    }
}
";

var tree = CSharpSyntaxTree.ParseText(code);

Console.WriteLine("=== SYNTAX TREE ROOT ===");
var root = tree.GetRoot();
Console.WriteLine(root.Kind());

// 1) Syntax-only: barcha identifierlarni topamiz
Console.WriteLine("\n=== IDENTIFIERS (SYNTAX) ===");
var identifiers = root.DescendantTokens()
                      .Where(t => t.IsKind(SyntaxKind.IdentifierToken))
                      .Select(t => t.ValueText)
                      .Distinct();

foreach (var id in identifiers)
  Console.WriteLine(id);

// 2) Semantic: Compilation + SemanticModel
var references = new[]
{
    MetadataReference.CreateFromFile(typeof(object).Assembly.Location),
    MetadataReference.CreateFromFile(typeof(Console).Assembly.Location),
    MetadataReference.CreateFromFile(typeof(Enumerable).Assembly.Location),
    MetadataReference.CreateFromFile(typeof(System.Collections.Generic.List<>).Assembly.Location),
};

var compilation = CSharpCompilation.Create(
    assemblyName: "DemoAssembly",
    syntaxTrees: new[] { tree },
    references: references,
    options: new CSharpCompilationOptions(OutputKind.ConsoleApplication));

var model = compilation.GetSemanticModel(tree);

// 3) Method invocation larni topib, qaysi method ekanini semantic bilan aniqlaymiz
Console.WriteLine("\n=== INVOCATIONS (SEMANTIC) ===");
var invocations = root.DescendantNodes().OfType<InvocationExpressionSyntax>();

foreach (var inv in invocations)
{
  var symbol = model.GetSymbolInfo(inv).Symbol as IMethodSymbol;
  if (symbol is null)
  {
    Console.WriteLine($"{inv}  ->  (symbol not resolved)");
    continue;
  }

  Console.WriteLine($"{inv}  ->  {symbol.ContainingType}.{symbol.Name}({string.Join(", ", symbol.Parameters.Select(p => p.Type.ToDisplayString()))})");
}

// 4) foreach “sugar” ni isbot: GetEnumerator/MoveNext/Current/Dispose’ni semanticda ko‘rsatish
Console.WriteLine("\n=== FOREACH INFO (SEMANTIC) ===");
var foreachStmt = root.DescendantNodes().OfType<ForEachStatementSyntax>().FirstOrDefault();
if (foreachStmt != null)
{
  var info = model.GetForEachStatementInfo(foreachStmt);
  Console.WriteLine($"GetEnumerator: {info.GetEnumeratorMethod}");
  Console.WriteLine($"MoveNext:      {info.MoveNextMethod}");
  Console.WriteLine($"Current:       {info.CurrentProperty}");
  Console.WriteLine($"Dispose:       {info.DisposeMethod}");
}
