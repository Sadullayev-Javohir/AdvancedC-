# 🔷 4-KUN: IL (Intermediate Language) va Opcodes

## 1️⃣ IL (Intermediate Language) nima?

**IL (Intermediate Language)** — bu .NET uchun platformaga bog‘liq bo‘lmagan oraliq kod.

👉 `C#, VB.NET yoki F#` → `Roslyn compiler` → `IL`
👉 `IL` → `CLR (Common Language Runtime)` → `JIT` → `Native Code`

### 📌 Asosiy xususiyatlar:

| Feature | Tavsif |
|---|---|
| **Cross-platform** | IL bir xil Windows/Linux/macOS’da ishlaydi |
| **Stack-based** | CPU registerlardan emas, stack ustida ishlaydi |
| **Low-level** | CPU’ya yaqin, lekin human-readable |
| **Assembly ichida saqlanadi** | `.exe` yoki `.dll` faylida |
| **Metadata bilan birga** | Type info, method signature, namespaces |

---

## 2️⃣ Opcodes nima?

**Opcode (Operation Code)** — bu IL dagi har bir buyruqning nomi.
* Masalan: `ldstr`, `stloc`, `add`, `call`, `ret`
* IL stack-based bo‘lganligi sababli, buyruqlar stack operatsiyalari sifatida ishlaydi.

### 🔹 Stack-based IL tushunchasi
IL kod CPU registerlariga emas, stack ustida ishlaydi: `Stack: top → pastga`

**Misol C#:**
```csharp
int x = 5;
int y = 3;
int z = x + y;
```

**IL:**
```text
ldloc.0    // x ni stack ga yuklaydi
ldloc.1    // y ni stack ga yuklaydi
add        // stack ustidagi ikkita qiymatni qo‘shadi
stloc.2    // natijani z ga saqlaydi
```

---

## 3️⃣ Eng ko‘p ishlatiladigan IL opcodes

| Opcode | Ma’nosi | Misol |
|---|---|---|
| `ldstr` | String literalni stack ga yuklash | `ldstr "Hello"` |
| `ldc.i4` | Integer literalni stack ga yuklash | `ldc.i4 5` |
| `ldloc` | Local variable’ni stack ga yuklash | `ldloc.0 (x)` |
| `stloc` | Stack ustidagi qiymatni local variable ga saqlash| `stloc.1 (y)` |
| `add` | Stack ustidagi ikkita qiymatni qo‘shish | `ldloc.0; ldloc.1; add` |
| `sub` | Ayirish | `ldloc.0; ldloc.1; sub` |
| `mul` | Ko‘paytirish | `ldloc.0; ldloc.1; mul` |
| `div` | Bo‘lish | `ldloc.0; ldloc.1; div` |
| `call` | Method chaqirish | `call void [mscorlib]System.Console::WriteLine(string)` |
| `ret` | Methoddan qaytish | `ret` |

---

## 4️⃣ Real C# → IL misol

**C# kodi:**
```csharp
using System;

class Program
{
    static void Main()
    {
        string s = "Hello IL";
        Console.WriteLine(s);
    }
}
```

**IL (simplified):**
```text
IL_0000: ldstr "Hello IL"        // stringni stack ga yuklaydi
IL_0005: stloc.0                  // stack dan s ga saqlaydi
IL_0006: ldloc.0                  // s ni stack ga yuklaydi
IL_0007: call void [mscorlib]System.Console::WriteLine(string)
IL_000c: ret                      // methoddan qaytadi
```

**Tahlil:**
* `ldstr "Hello IL"` → Stack ga "Hello IL" yuklaydi.
* `stloc.0` → Local variable `s` ga saqlaydi.
* `ldloc.0` → `s` stack ga yuklanadi.
* `call` → `Console.WriteLine` chaqiriladi.
* `ret` → Methoddan chiqadi.

---

## 5️⃣ IL’ning stack ishlash printsipi

Har bir operation stack ustida ishlaydi.

**Masalan:**
```text
ldc.i4 5    // 5 stack ga
ldc.i4 3    // 3 stack ga
add         // 5+3 = 8
stloc.0     // local var ga saqlaydi
```

**Stack ustida visual:**
```text
Step 1: ldc.i4 5   → Stack: [5]
Step 2: ldc.i4 3   → Stack: [5,3]
Step 3: add        → Stack: [8]
Step 4: stloc.0    → Stack: []
```

---

## 6️⃣ Method Call va Return

**C#:**
```csharp
int Add(int a, int b) => a + b;
```

**IL:**
```text
ldarg.0       // a
ldarg.1       // b
add           // a+b
ret           // natijani qaytaradi
```
* `ldarg` → argumentni stack ga yuklaydi.
* `add` → stack ustida qo‘shadi.
* `ret` → natijani return qiladi.

---

## 7️⃣ Branching & Comparison

IL shuningdek if, loops, comparison kabi operatsiyalarni ham qo‘llab-quvvatlaydi.

**C#:**
```csharp
if(x > 5) Console.WriteLine("Hi");
```

**IL:**
```text
ldloc.0        // x
ldc.i4.5
ble.s IL_000a  // x <= 5 bo‘lsa, branch
ldstr "Hi"
call void [mscorlib]System.Console::WriteLine(string)
IL_000a: ret
```
* `ble.s` → branch if less or equal (Stack ustida ishlaydi).

---

## 8️⃣ IL’ni o‘rganishning afzalliklari

* ✔ Dastur qanday CPU code ga aylanayotganini tushunish.
* ✔ **Debugging:** JIT compilation va optimizer’larni tushunish.
* ✔ **Performance tuning:** Boxing, unboxing, locals vs stack.
* ✔ **Reflection & Code generation:** IL emit orqali dynamic method yaratish.
* ✔ **Roslyn + IL + JIT** → professional .NET engineer darajasi.

---

## 9️⃣ To‘liq pipeline bilan bog‘lash

```text
C# Source Code
   ↓ Roslyn Compiler
Tokenization → Lexing
   ↓ Parsing
Syntax Tree (AST)
   ↓ Semantic Analysis
Semantic Model + Binding
   ↓ Diagnostics
Errors / Warnings
   ↓ Emit
IL Code (Opcodes: ldstr, stloc, add ...)
   ↓ CLR / JIT
Native Code
   ↓ CPU Execution
```

---

## 🔥 Xulosa

* 🔹 **IL** = C# kodining oraliq, platformaga bog‘liq bo‘lmagan shakli.
* 🔹 **Opcodes** = har bir buyruq, stack-based.
* 🔹 `ldstr`, `stloc`, `ldloc`, `add`, `call`, `ret` → eng asosiy buyruqlar.
* 🔹 **IL’ni tushunish** = .NET’ni chuqur o‘rganish, debugging va optimization.