# 🔷 3-KUN: ROSLYN COMPILER (Deep Dive)

## 📌 Roslyn nima?
**Roslyn** — bu C# va VB.NET uchun zamonaviy compiler platforma.

👉 **Oldingi compilerlardan farqi:**
* Faqat compile qilmaydi.
* Balki kodni analiz qilish API’larini ham beradi.

### 📌 Roslyn pipeline
```text
Source Code
   ↓
Syntax Tree (AST)
   ↓
Semantic Model
   ↓
IL Code
```

---

## 🔶 1. SYNTAX TREE (AST)

### 📌 Syntax Tree nima?
**Syntax Tree (Abstract Syntax Tree)** — bu kodning strukturaviy daraxt ko‘rinishi.
👉 Ya’ni: Kod qanday yozilganini strukturaga aylantiradi.

### 📌 Misol
**C# kod:**
```csharp
int x = 5 + 3;
```

**📌 Daraxt ko‘rinishi:**
```text
VariableDeclaration
 ├── Type: int
 ├── Identifier: x
 └── Expression (+)
      ├── 5
      └── 3
```

### 📌 Muhim xususiyatlari
* ✔ Faqat syntax (yozilish shakli).
* ❌ Ma’no (type, value) yo‘q.

### 📌 Xatolik bo‘lsa ham ishlaydi
```csharp
int x = ;
```
👉 Shunda ham Syntax Tree hosil bo‘ladi (IDE qizil chiziq chizishi shuning uchun mumkin).

### 📌 Roslyn’dagi klasslar
* `SyntaxNode`
* `SyntaxToken`
* `SyntaxTrivia`

### 📌 Real kod (Roslyn bilan)
```csharp
var tree = CSharpSyntaxTree.ParseText("int x = 5 + 3;");
var root = tree.GetRoot();
```

### 📌 Qayerda ishlatiladi?
* IntelliSense
* Code formatting
* Syntax highlighting
* Refactoring

---

## 🔶 2. SEMANTIC MODEL

### 📌 Semantic Model nima?
**Semantic Model** — bu kodning ma’nosini tushuntiradi.
👉 Ya’ni: Type nima? Variable qayerdan kelgan? Method qaysi?

### 📌 Misol
```csharp
int x = 5;
```
* **Syntax Tree:** 👉 “int”, “x”, “5” — oddiy node.
* **Semantic Model:** 👉 `int` → `System.Int32`, `x` → local variable, `5` → literal (int).

### 📌 Muhim xususiyatlari
* ✔ Type info beradi.
* ✔ Symbol resolution qiladi.
* ✔ Scope tekshiradi.
* ✔ Compile error aniqlaydi.

### 📌 Real kod
```csharp
var model = compilation.GetSemanticModel(tree);

var node = root.DescendantNodes().First();
var typeInfo = model.GetTypeInfo(node);
```

### 📌 Qanday savollarga javob beradi?
* Bu variable qaysi type?
* Bu method qayerdan kelgan?
* Overload qaysi biri?
* Nullablemi?

---

## 🔶 3. SYNTAX vs SEMANTIC (ENG MUHIM FARQ)

| Xususiyat | Syntax Tree | Semantic Model |
|---|---|---|
| **Nima?** | Strukturasi | Ma’nosi |
| **Type biladimi?** | ❌ | ✔ |
| **Error tekshiradimi?** | ❌ | ✔ |
| **Tezligi** | Juda tez | Sekinroq |
| **IDE ishlatadimi?** | ✔ | ✔ |

> **📌 Oddiy tushuncha:**
> 👉 **Syntax:** “Kod qanday yozilgan?”
> 👉 **Semantic:** “Kod nimani anglatadi?”

---

## 🔶 4. REAL MISOL (chalkash joy)

```csharp
var x = Add(5, 3);
```

* **Syntax Tree:** `var`, `x`, `Add`, `(5,3)` 👉 Lekin: ❌ `Add` nima? Bilmaydi.
* **Semantic Model:** `Add` → qaysi method, `return type` → int, `x` → int.

---

## 🔶 5. ROSLYN NEGA MUHIM?

**📌 1. IDE ichida ishlaydi:** Visual Studio, Rider. 👉 IntelliSense aynan shundan.
**📌 2. Code Analyzer yozish mumkin:** Masalan: “Naming rule buzildi”, “Unused variable bor”.
**📌 3. Source Generator:** Compile vaqtida avtomatik kod yozadi.
**📌 4. Refactoring tools:** Masalan: Rename, Extract method.

---

## 🔶 6. INTERNAL PIPELINE (DEEP)

1. Parse → **Syntax Tree**
2. Bind → **Semantic Model**
3. Analyze → **Errors**
4. Emit → **IL Code**

---

## 🔶 7. SYNTAX TREE TURLARI

* **📌 Full Syntax Tree:** Barcha node’lar.
* **📌 Syntax Tokens:** Keywords (`int`, `class`).
* **📌 Trivia:** Bo‘sh joy, comment.

---

## 🔶 8. SEMANTIC MODEL ICHIDA NIMA BOR?

* Symbol table
* Type system
* Namespace resolution
* Assembly reference

---

## 🔥 FINAL XULOSA

👉 **Roslyn 2 ta asosiy narsa beradi:**

🔹 **1. Syntax Tree:**
* Kod strukturasi.
* Tez ishlaydi.
* Error bo‘lsa ham ishlaydi.

🔹 **2. Semantic Model:**
* Kod ma’nosi.
* Type va symbol beradi.
* Compile logic shu yerda.

👉 **Eng muhim insight:**
* **Syntax Tree** → "Qanday yozilgan"
* **Semantic Model** → "Nimani anglatadi"

👉 **Professional darajadagi xulosa:**
* **Syntax Tree** → frontend parsing
* **Semantic Model** → compiler intelligence