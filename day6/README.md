# 🔷 6-KUN: JIT COMPILATION — .NET kodni natijaviy CPU code’ga aylantirish

## 1️⃣ JIT Compilation nima?

**JIT (Just-In-Time) Compilation** — bu IL (Intermediate Language) kodni runtime paytida CPU tushunadigan native code ga aylantirish jarayoni.

👉 `IL code` → `CLR` → `JIT` → `Native code` → `CPU execute`
👉 `Stack-based IL` → `CPU registers` va `native instructions`

### 🔹 JIT’ning asosiy vazifalari:
* IL kodni native machine code ga aylantirish.
* Method’larni runtime profiling asosida optimize qilish.
* Stack va heap operatsiyalarini tayyorlash.
* Security va verification tekshirish.

---

## 2️⃣ JIT vs Ahead-of-Time (AOT)

| Feature | JIT | AOT |
|---|---|---|
| **Compilation time** | Runtime | Compile-time |
| **Optimization** | Profile-based | Static |
| **Memory footprint** | Runtime overhead | Precompiled |
| **Startup** | Sezilarli sekinroq | Tezroq |
| **Flexibility** | Yes | Limited |

---

## 3️⃣ Normal JIT vs Econo JIT

### 🔹 Normal JIT
* Har bir method chaqirilganda IL → native code compile qilinadi.
* Optimized machine code hosil qiladi.
* Runtime profiling imkoniyatlari → branch prediction, inlining.
* Performance oriented, ammo compilation overhead bor.

**Misol:**
```csharp
void Foo() { Console.WriteLine("Hello"); }
```
👉 `Normal JIT` → `Foo()` chaqirilganda `IL` → `Native` → `CPU execute`.

### 🔹 Econo JIT (Economical / Quick JIT)
* Tezkor, kam resurs sarflaydi.
* Minimal optimizatsiya bilan compile qiladi.
* Startup vaqtini kamaytirish uchun ishlatiladi.
* Mobile / constrained environment’larda qulay.

**Farq:**

| Feature | Normal JIT | Econo JIT |
|---|---|---|
| **Optimization** | Full | Minimal |
| **Compilation speed**| Medium | Fast |
| **Native code quality**| High | Lower |

---

## 4️⃣ Tiered Compilation (Darajali JIT)

**Tiered Compilation** = JIT compilationning ikki bosqichli strategiyasi.
👉 Ilk chaqirishda → Quick JIT (Econo)
👉 Keyin method ko‘p chaqirilsa → Optimized Normal JIT

### 🔹 Advantages:
* **Faster startup** → ilova tez yuklanadi.
* **Performance optimization** → ko‘p ishlatiladigan methods yuqori sifatli native code bilan compile qilinadi.
* **Memory savings** → kam ishlatilgan methods minimal code bo'ladi.

### 🔹 Workflow:
1. `Method call #1` → Econo JIT → Quick Native Code → CPU execute.
2. `Method call #N (hot path)` → Normal JIT → Optimized Native Code → CPU execute.

---

## 5️⃣ JIT pipeline CLR bilan

```text
C# Source Code
   ↓ Roslyn Compiler
IL Code
   ↓ CLR
JIT Compilation (Econo / Normal / Tiered)
   ↓ CPU Native Instructions
   ↓ Execution
```

### 🔹 Stack + Registers Mapping
* Stack-based IL → CPU registers va stack frames.
* Local variables → registers yoki stack.
* Method calls → call stack.

---

## 6️⃣ JIT optimization imkoniyatlari

* **Inlining** → kichik method’larni chaqirmasdan stack ustida joylashtirish.
* **Loop unrolling** → takrorlanuvchi looplarni optimizatsiya qilish.
* **Constant folding** → compile-time calculation.
* **Branch prediction hints** → CPU pipeline uchun.

### 🔹 Misol:
**C#:**
```csharp
int Sum(int a, int b) => a + b;
```
* **Normal JIT** → optimized, `a+b` → single instruction.
* **Econo JIT** → `a+b` → standard stack instructions.

---

## 7️⃣ Real misol: Tiered JIT

```csharp
void HotMethod() { /* ko‘p ishlatiladi */ }
void ColdMethod() { /* kam ishlatiladi */ }
```
* `HotMethod` → Normal JIT → Optimized native code.
* `ColdMethod` → Econo JIT → Minimal code.
* **Tiered Compilation** → startup tez, performance yuqori.

---

## 8️⃣ Key Insight

* **JIT** → IL → Native code, runtime optimize qiladi.
* **Normal JIT** → full optimization, performance oriented.
* **Econo JIT** → minimal optimization, fast startup.
* **Tiered Compilation** → startup + runtime performance balancing.

---

## 9️⃣ CLR + JIT + IL overview diagram

```text
C# Source
   ↓ Roslyn Compiler
IL Code (Opcodes)
   ↓ CLR
JIT Compilation:
   ├─ Econo JIT → Fast Native Code
   ├─ Normal JIT → Optimized Native Code
   └─ Tiered → Econo first, then Normal for hot paths
   ↓ CPU Execution
```