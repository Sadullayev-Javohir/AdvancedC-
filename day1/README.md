# 1-kun: .NET Ekotizimi. Framework vs Core vs .NET 5+. BCL nima?

## 🔷 1. .NET EKOTIZIMI (Umumiy tushuncha)

### 📌 .NET nima?
**.NET** — bu Microsoft tomonidan yaratilgan platforma (framework + runtime + tools) bo‘lib, u orqali quyidagilarni yaratish mumkin:
* Web ilovalar (ASP.NET)
* Desktop ilovalar (WPF, WinForms)
* Mobile (Xamarin, MAUI)
* Game (Unity)
* Cloud (Azure)
* Microservices

### 📌 .NET qanday ishlaydi (ichki jarayon)
1. Sen **C#** kod yozasan.
2. Kod **Roslyn compiler** orqali:
    * **IL** (Intermediate Language) ga o‘giriladi.
3. IL kod:
    * **CLR** (Common Language Runtime) tomonidan ishlatiladi.
4. CLR:
    * IL → Machine Code (**JIT** orqali).
    * Memory management (**GC**).
    * Exception handling.

### 📌 .NET asosiy komponentlari

| Qism | Vazifasi |
|---|---|
| **CLR** | Kodni bajaradi (runtime) |
| **BCL** | Tayyor classlar (string, list...) |
| **Compiler** | C# → IL |
| **SDK** | Build, run, publish qilish |
| **Runtime** | Ilovani ishga tushiradi |

---

## 🔷 2. .NET FRAMEWORK vs .NET CORE vs .NET 5+
Bu uchta .NET evolyutsiyasi bosqichlari hisoblanadi.

### 🟦 1. .NET Framework (eski)
📅 **2002 yilda chiqqan**
* ✔ **Xususiyatlari:** Faqat Windows’da ishlaydi, katta va og‘ir, ASP.NET (eski), WinForms, WPF.
* ❌ **Kamchiliklari:** Cross-platform emas, performance pastroq, modern emas.

### 🟩 2. .NET Core (modern boshlanishi)
📅 **2016 yilda chiqqan**
* ✔ **Xususiyatlari:** Cross-platform (Windows, Linux, Mac), lightweight, high performance, open-source.
* ✔ **Qaysilar bor:** ASP.NET Core, Console apps, Microservices.

### 🟥 3. .NET 5+ (unified platform)
📅 **2020 dan boshlab**
* ✔ **Maqsadi:** .NET Framework + Core → bitta platformaga birlashtirish.
* ✔ **Versiyalar:** .NET 5, .NET 6 (LTS), .NET 7, .NET 8 (LTS), .NET 9 (yangi).

### 🔥 Farqlar jadvali

| Xususiyat | .NET Framework | .NET Core | .NET 5+ |
|---|---|---|---|
| **Platform** | Windows only | Cross-platform | Cross-platform |
| **Performance** | Past | Yuqori | Eng yuqori |
| **Open-source** | ❌ | ✔ | ✔ |
| **Future support**| ❌ | ✔ | ✔ |
| **Microservices** | ❌ | ✔ | ✔ |

> **📌 Muhim xulosa:**
> * **.NET Framework** — deyarli ishlatilmaydi (legacy).
> * **.NET Core** — o‘rnini .NET 5+ egallagan.
> * **.NET 6+** — real production standard.

---

## 🔷 3. BCL (Base Class Library) — ENG MUHIM QISM

### 📌 BCL nima?
**BCL** — bu .NET ichidagi tayyor classlar kutubxonasi.
👉 Ya’ni: Sen har safar noldan yozmaysan, balki tayyor narsalarni ishlatasan.

### 📌 BCL ichida nimalar bor?
1. **Primitive va asosiy tiplar:** `int`, `string`, `bool`, `double`
2. **Collectionlar:** `List<T>`, `Dictionary<TKey, TValue>`, `Queue<T>`, `Stack<T>`
3. **IO (File bilan ishlash):** `File`, `Stream`, `Directory`
4. **Networking:** `HttpClient`, `Socket`
5. **Threading:** `Thread`, `Task`, `async/await`
6. **LINQ:** `Where()`, `Select()`, `OrderBy()`
7. **Reflection:** `Type`, `Assembly`, `Activator`

### 📌 Misol
```csharp
List<int> numbers = new List<int>();
numbers.Add(10);
numbers.Add(20);

var result = numbers.Where(x => x > 10);
```
👉 Bu yerda: **List** → BCL, **Where** → LINQ (BCL ichida).

### 📌 BCL vs FCL
* **Oldin:** FCL (Framework Class Library) — katta tushuncha, BCL — uning ichidagi asosiy qismi.
* **Hozir esa:** 👉 Ko‘pincha **BCL** = butun library sifatida ishlatiladi.

---

## 🔷 4. CLR (bonus — juda muhim)

### 📌 CLR nima qiladi?
* Memory management (Garbage Collector)
* Exception handling
* Security
* Threading
* JIT compilation

### 📌 JIT nima?
**JIT (Just-In-Time Compiler):** 👉 IL kodni real CPU kodiga o‘giradi.

---

## 🔷 5. .NET SDK vs Runtime

* **SDK:** Developer uchun. Build qilish (`dotnet build`), run qilish (`dotnet run`).
* **Runtime:** Faqat ishlatish uchun. User kompyuterida bo‘ladi.

---

## 🔷 6. .NET CLI (commandlar)

```bash
dotnet new console
dotnet build
dotnet run
dotnet publish
```

---

## 🔷 7. .NET Architecture (soddalashtirilgan)

```text
C# Code
   ↓
Compiler (Roslyn)
   ↓
IL Code
   ↓
CLR
   ↓
Machine Code
   ↓
CPU
```

---

## 🔥 FINAL XULOSA

👉 **.NET bu:** Platforma + runtime + kutubxonalar + toolset

👉 **Eng muhim tushunchalar:**
* **CLR** → bajaradi
* **BCL** → tayyor classlar
* **IL** → oraliq kod
* **JIT** → tezlashtiradi

👉 **Evolyutsiya:** .NET Framework → .NET Core → .NET 5+

👉 **Bugungi real dunyo:**
* ✔ .NET 6/7/8/9 ishlatiladi.
* ✔ ASP.NET Core eng muhim skill.
* ✔ Cross-platform standart.