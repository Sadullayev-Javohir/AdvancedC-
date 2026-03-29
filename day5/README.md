# 🔷 5-KUN: CLR (Common Language Runtime) va uning ichki ishlash prinsiplari

## 1️⃣ CLR nima?
**Common Language Runtime** — bu .NET platformasidagi virtual mashina va runtime muhit.

* C#, VB.NET, F# kabi tillarda yozilgan kodni execute qilish uchun xizmat qiladi.
* Kodni platformaga moslashtirish (JIT).
* Xotira boshqaruvi, type safety, security, exception handling.

### 🔹 CLR asosiy vazifalari:

| Vazifa | Tavsif |
|---|---|
| **Execution** | IL kodni JIT orqali CPU uchun native code ga o‘giradi |
| **Memory Management** | Heap, Stack, Garbage Collection |
| **Type Safety** | Run-time type checking |
| **Security** | Code access security, sandboxing |
| **Exception Handling** | Try-catch-finally boshqaruvi |
| **Interoperability** | COM, native API bilan ishlash |

---

## 2️⃣ Virtual Mashina vazifasi
**Virtual Mashina (VM)** = IL kodni platformaga bog‘liq bo‘lmagan koddan native code’ga o‘girish muhitidir.

### 🔹 CLR Virtual Machine vazifalari
* **JIT Compilation** → IL → Native code
* **Stack va Heap management** → method call stack + objects heap
* **Type Checking** → runtime type errors
* **Exception Handling** → catch/throw
* **Security Enforcement** → sandbox, code access policy

---

## 3️⃣ CLR ichidagi xotira boshqaruvi
.NET’da Memory Management asosan ikki qismga bo‘linadi:

### 🔹 1. Stack (Method / Local Variables)
* Method chaqirilganda hosil bo‘ladi.
* Primitive va reference type’larning local variablelari saqlanadi.
* LIFO (Last In, First Out) printsipida ishlaydi.
* Stack’dagi ma’lumotlar automatic release qilinadi, GC kerak emas.

```text
Stack:
Top → x=5
       y=10
```

### 🔹 2. Heap (Managed Heap)
* Reference type object’lar uchun.
* **Garbage Collector (GC)** tomonidan boshqariladi.
* Object yaratishda memory allocation → `new`.

```csharp
class Person { public string Name; }

Person p = new Person();
```
* `p` reference → Stack
* `new Person()` → Heap
* GC → reference yo‘q bo‘lganda objectni tozalaydi.

### 🔹 CLR Memory Layout
```text
Stack          → Local variables, method call frames
Heap           → Objects (reference types)
Large Object Heap → >85kB objectlar
Managed Heap   → GC tomonidan boshqariladi
Code Segment   → JIT compiled native code
Metadata       → Type info, method signature, reflection
```

---

## 4️⃣ Garbage Collection (GC)

### 🔹 GC vazifasi:
* Memory leaks oldini olish.
* Ob’ektlar “reachable” bo‘lmasa, ularni avtomatik free qiladi.

### 🔹 Generatsiyalar (Generations):

| Generation | Tavsif |
|---|---|
| **Gen 0** | Yangi yaratilgan ob’ektlar |
| **Gen 1** | Oraliq ob’ektlar, ko‘p ishlamaganlar |
| **Gen 2** | Uzoq umr ko‘radigan ob’ektlar (cache, static) |

* **GC algoritmi:** mark & sweep + compact → fragmentation oldini oladi.

### 🔹 Example
```csharp
Person p1 = new Person(); // Heap da object
p1 = null;                // Object unreachable → GC tomonidan cleanup
```

---

## 5️⃣ Security in CLR

### 🔹 Code Access Security (CAS)
* .NET kodining resource accessini cheklash.
* Example: fayl system, network, registry.

```csharp
[PermissionSet(SecurityAction.Demand, Name="FullTrust")]
public void AccessFile() { ... }
```

### 🔹 Type Safety
* IL + CLR → Type Safety.
* Misol: `int` ga `string` qiymat yuklab bo‘lmaydi.
* Stack overflow, buffer overflow’larni kamaytiradi.

### 🔹 Verification
* JIT compilation paytida IL code verify qilinadi.
* Unauthorized memory access oldini oladi.

---

## 6️⃣ CLR Exception Handling
* IL code try/catch/finally support qiladi.
* Stack unwinding → local variable cleanup.
* Managed exception objects → heap da saqlanadi.

```csharp
try {
    int x = 5/0;
} catch(DivideByZeroException ex) {
    Console.WriteLine(ex.Message);
} finally {
    Console.WriteLine("Cleanup");
}
```
👉 *IL → throw / catch / finally opcodes bilan amalga oshiriladi.*

---

## 7️⃣ CLR + IL pipeline bog‘lanishi

```text
C# Source Code
   ↓ Roslyn Compiler
IL Code (Opcodes)
   ↓ CLR
Stack & Heap Management
JIT → Native Code
Execution
Memory & Security Boshqaruvi
GC
Exception Handling
```

---

## 8️⃣ CLR vazifalari xulosa

| Vazifa | Tavsif |
|---|---|
| **JIT Compilation** | IL → Native code |
| **Memory Management** | Stack, Heap, Large Object Heap, GC |
| **Type Safety** | Primitive + Reference type checking |
| **Security** | CAS, verification, sandboxing |
| **Exception Handling**| try/catch/finally, stack unwinding |
| **Interoperability** | COM, P/Invoke, native API |

### 🔹 Key Insight
* **CLR** = .NET’ning Virtual Mashinasi + Memory + Security manager.
* `IL` → `CLR` → `Native` → `CPU`.
* **Managed memory + type safety + code access security** → .NET xavfsiz va barqaror ishlashini ta’minlaydi.