# 🔷 2-KUN: COMPILATION PIPELINE

## 📌 Umumiy zanjir

```text
C# Source Code
   ↓
Roslyn Compiler
   ↓
IL (Intermediate Language)
   ↓
CLR (JIT Compiler)
   ↓
Native Machine Code
   ↓
CPU Execution
```

---

## 🔶 1. SOURCE CODE (C#)

### 📌 Bu nima?
Sen yozadigan oddiy kod:

```csharp
int x = 5;
int y = 10;
Console.WriteLine(x + y);
```

👉 **Bu hali CPU tushunadigan kod emas.**

---

## 🔶 2. ROSLYN COMPILER

### 📌 Roslyn nima?
**Roslyn** — bu .NET’ning rasmiy C# compileri.

### 📌 Roslyn nima qiladi?
* ✔ **1. Syntax tekshiradi:** `int x = ;` ❌ xatolik beradi.
* ✔ **2. Semantic tekshiradi:** `int x = "hello";` ❌ type mismatch.
* ✔ **3. IL kod generatsiya qiladi:** 👉 **Eng muhim vazifa:** C# → IL ga o‘tkazadi.

### 📌 Roslyn ichki bosqichlari
```text
Source Code
   ↓
Lexical Analysis (tokenlarga ajratadi)
   ↓
Syntax Tree (AST)
   ↓
Semantic Analysis
   ↓
IL Generation
```

---

## 🔶 3. IL (INTERMEDIATE LANGUAGE)

### 📌 IL nima?
**IL** — bu platformaga bog‘liq bo‘lmagan oraliq kod.
👉 CPU emas, lekin C# ham emas.

### 📌 Misol
**C#:**
```csharp
int sum = x + y;
```

**IL:**
```text
ldloc.0
ldloc.1
add
stloc.2
```

### 📌 IL xususiyatlari
* Cross-platform
* Stack-based
* Low-level (CPU ga yaqin)
* Assembly (`.dll` / `.exe`) ichida saqlanadi

### 📌 Assembly nima?
👉 Compile bo‘lgandan keyin `.exe` yoki `.dll` fayllar hosil bo'ladi. Ularning ichida quyidagilar bo'ladi:
* IL kod
* Metadata (type info)

---

## 🔶 4. CLR (COMMON LANGUAGE RUNTIME)

### 📌 CLR nima qiladi?
**CLR** — bu .NET runtime engine.
👉 U IL kodni bajaradi.

### 📌 CLR vazifalari
* JIT compilation
* Garbage Collection
* Exception handling
* Security
* Threading

---

## 🔶 5. JIT (JUST-IN-TIME COMPILER)

### 📌 JIT nima?
**JIT** — bu CLR ichidagi komponent bo‘lib:
👉 IL → Native Code ga o‘giradi.

### 📌 Qachon ishlaydi?
❗ **Runtime paytida** (dastur ishga tushganda).

### 📌 Qanday ishlaydi?
```text
Method chaqirildi
   ↓
JIT uni compile qiladi
   ↓
Native code ga aylantiradi
   ↓
Keyingi safar qayta ishlatadi
```

### 📌 Misol
```csharp
void Add()
{
    int x = 5;
    int y = 10;
    Console.WriteLine(x + y);
}
```
👉 `Add()` birinchi marta chaqirilganda: JIT ishlaydi, Native code yaratadi.
👉 Keyingi chaqiriqlarda: Tayyor kod ishlatiladi.

### 📌 JIT turlari

| Tur | Tavsif |
|---|---|
| **Normal JIT** | Method chaqirilganda |
| **Eager JIT** | Oldindan compile qilib qo'yish |
| **Tiered JIT** | Optimization bilan ishlash |

---

## 🔶 6. NATIVE CODE (CPU CODE)

### 📌 Bu nima?
👉 Eng oxirgi bosqich:
* 0 va 1 lar (machine code)
* CPU bajaradi

### 📌 Platformaga bog‘liq
* Windows → x64
* Linux → x64 / ARM
* Mac → ARM

---

## 🔶 7. TO‘LIQ PIPELINE (REAL HAYOTDA)

1. Sen kod yozasan (C#)
2. `dotnet build`
   ↓
3. Roslyn → IL + Assembly
   ↓
4. `dotnet run`
   ↓
5. CLR ishga tushadi
   ↓
6. JIT → Native code
   ↓
7. CPU bajaradi

---

## 🔥 MUHIM TUSHUNCHALAR

### 📌 Nega 2 bosqichli compilation?

👉 **C++:** Code → Native
👉 **.NET:** Code → IL → Native

✔ **Afzalliklari:**
1. **Cross-platform:** Bir xil IL → har xil OS’da ishlaydi.
2. **Security:** CLR tekshiradi.
3. **Optimization:** JIT runtime’da optimizatsiya qiladi.
4. **Versioning:** Librarylar oson boshqariladi.

---

## 🔶 8. AOT (Ahead-of-Time) — BONUS

### 📌 Bu nima?
JIT o‘rniga: 👉 Oldindan native code ga compile qilish.

### 📌 Qayerda ishlatiladi?
* iOS
* Blazor WebAssembly
* Native AOT (.NET 8)

### 📌 Farqi

| Xususiyat | JIT | AOT |
|---|---|---|
| **Compile vaqti** | Runtime compile | Oldindan compile |
| **Ishga tushish tezligi**| Sekin start | Tez start |
| **Moslashuvchanlik** | Flexible | Kamroq flexible |

---

## 🔥 FINAL XULOSA

👉 **To‘liq zanjir:**
`C# → Roslyn → IL → CLR → JIT → Native → CPU`

👉 **Eng muhim 3 narsa:**
1. **Roslyn** → compile qiladi
2. **IL** → universal kod
3. **JIT** → tez ishlashni ta’minlaydi

👉 **Eng katta insight:**
💡 *.NET to‘g‘ridan-to‘g‘ri CPU’da ishlamaydi → Har doim CLR orqali ishlaydi.*