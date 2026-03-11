class Student
{
    public string Name;

    public Student(string name)
    {
        Name = name;
        Console.WriteLine($"{Name} object yaratildi");
    }

    ~Student()
    {
        Console.WriteLine($"{Name} object uchun finalizer ishladi");
    }
}

class Program
{
    static void CreateStudent()
    {
        Student s = new Student("Ali");
    }

    static void Main()
    {
        CreateStudent();
        Console.WriteLine("CreateStudent tugadi");
        
        GC.Collect();
        GC.WaitForPendingFinalizers();
        Console.WriteLine("Dastur tugadi");
    }
}