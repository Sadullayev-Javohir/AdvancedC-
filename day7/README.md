# 🔷 7-KUN: MANAGED vs UNMANAGED CODE va Native Resources

## 1️⃣ Managed Code nima?

**Managed code** — bu kod .NET CLR (Common Language Runtime) tomonidan boshqariladi.
* Memory, type safety, garbage collection va security CLR tomonidan avtomatik nazorat qilinadi.
* **Misol:** C#, VB.NET, F#.

### 🔹 Managed code xususiyatlari:

| Feature | Tavsif |
|---|---|
| **Memory Management** | CLR GC orqali boshqariladi |
| **Type Safety** | CLR type checking |
| **Security** | CAS (Code Access Security) va sandbox |
| **Interop** | Unmanaged code bilan ishlash mumkin |
| **Exception Handling**| CLR exception system orqali |

**Misol:**
```csharp
string s = "Hello, Managed!";
int x = 42;
```
* `s` → Heap
* `x` → Stack
* CLR GC ob’ektlarni avtomatik tozalaydi.

---

## 2️⃣ Unmanaged Code nima?

**Unmanaged code** — bu kod CLR tomonidan boshqarilmaydi, operatsion tizim yoki boshqa runtime’ga bog‘liq.
* **Misol:** C, C++ native libraries, Win32 API.
* Xotira va resource management developer’ga yuklanadi.

### 🔹 Unmanaged code xususiyatlari:

| Feature | Tavsif |
|---|---|
| **Memory Management** | Manual (malloc/free yoki new/delete) |
| **Type Safety** | Compiler check, runtime yo‘q |
| **Security** | OS yoki developer nazorat qiladi |
| **Exception Handling**| OS yoki language specific |
| **Interop** | Managed code bilan P/Invoke yoki COM orqali bog‘lanadi |

**Misol:**
```cpp
// C++ unmanaged code
char* buffer = (char*)malloc(100);
// ishlatish
free(buffer);
```
👉 *Developer `free()` chaqirmasa → memory leak bo'ladi.*

---

## 3️⃣ Managed vs Unmanaged diagram

```text
Managed Code (C#, VB.NET, F#)
   ├─ CLR + JIT
   ├─ Garbage Collection
   ├─ Type Safety
   └─ Exception Handling

Unmanaged Code (C, C++)
   ├─ Direct OS execution
   ├─ Manual Memory Management
   ├─ Unsafe pointers
   └─ OS-level exception handling
```

---

## 4️⃣ Native Resources bilan ishlash

**Native Resources** = CLR tashqarisidagi resurslar:
* Fayllar (`FileStream`, FileHandle)
* Network sockets (`TcpClient`, Socket)
* Database connections (ODBC, native drivers)
* Graphics handles, device contexts

### 🔹 Masala
Managed code GC orqali xotirani tozalaydi, lekin native resource’larni CLR avtomatik free qilmaydi.

```csharp
FileStream fs = new FileStream("file.txt", FileMode.Open);
// ishlatish
fs.Close(); // yoki using statement
```
👉 *Agar `fs.Close()` chaqirilmasa → file handle leak bo'ladi.* CLR GC xotirani tozalaydi, lekin OS resource qoladi.

---

## 5️⃣ IDisposable va Using

### 🔹 IDisposable interfeisi
* Native resource’larni manually release qilish uchun ishlatiladi.
* **Pattern:** `Dispose()`

```csharp
using (FileStream fs = new FileStream("file.txt", FileMode.Open))
{
    // file bilan ishlash
} // avtomatik fs.Dispose() chaqiriladi
```
* CLR GC ob’ektni heap’dan tozalaydi.
* `Dispose()` → OS resource’larni free qiladi.

### 🔹 Pattern summary

| Concept | Managed | Unmanaged |
|---|---|---|
| **Memory** | CLR GC | Manual (malloc/free) |
| **Resource** | CLR handles only managed objects| Developer responsible (file, network, socket) |
| **Safety** | Type safe | Unsafe pointers possible |
| **Clean-up** | Automatic | Manual / IDisposable |

---

## 6️⃣ Interop: Managed ↔ Unmanaged

* **P/Invoke** → unmanaged DLL chaqirish.
* **COM Interop** → old Windows COM components bilan ishlash.
* **SafeHandle** → native handles bilan managed wrapper.

```csharp
[DllImport("user32.dll", CharSet = CharSet.Unicode)]
public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);
```
* CLR stack safety + GC bilan ishlash.
* Native resource’lar OS tomonidan boshqariladi.

---

## 7️⃣ Key Insights

* **Managed code** → CLR tomonidan memory + security boshqariladi.
* **Unmanaged code** → developer / OS tomonidan boshqariladi.
* **Native resources** → har doim developer nazorati kerak, `Dispose()` yoki `using` pattern orqali.
* **Interop** → Managed + Unmanaged birga ishlashi mumkin.

---

## 8️⃣ Managed vs Unmanaged + Native Resource overview diagram

```text
Managed Code
 ├─ CLR
 │   ├─ GC → heap memory
 │   └─ Type Safety + Security
 └─ IDisposable → Native resource cleanup

Unmanaged Code
 ├─ OS
 │   ├─ Manual Memory Management
 │   └─ Native Resources (Files, Sockets)
 └─ Developer responsibility
```