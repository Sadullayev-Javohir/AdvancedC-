// string a = new string(new[] {'t', 'e', 's', 't'});
// string b =  "test";
//
// Console.WriteLine(object.ReferenceEquals(a, b));
//
// a = string.Intern(a);
// Console.WriteLine(object.ReferenceEquals(a, b));

string a = "test";
string b = new string(new[] {'t', 'e', 's', 't'});

// Console.WriteLine(string.IsInterned(a) != null);
Console.WriteLine(string.IsInterned(b));