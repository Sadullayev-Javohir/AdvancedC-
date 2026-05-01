// class Animal {public string Name { get; set; }}
//
// class Dog : Animal
// {
//     public void Bark() => Console.WriteLine("Woof");
// }
//
//
// class Program
// {
//     static void Main()
//     {
//         IEnumerable<Dog> dogs = new List<Dog>()
//         {
//             new Dog() {Name = "Rex"},
//             new Dog() {Name = "Obcherka"}
//         };
//         IEnumerable<Animal> animals = dogs;
//
//         foreach (var animal in animals) Console.WriteLine(animal.Name);
//     }   
// }

// class Program
// {
//     static void Main()
//     {
//         IEnumerable<string> strings = new List<string>
//         {
//             "Hello",
//             "World"
//         };
//
//         IEnumerable<object> objects = strings;
//
//         foreach (object obj in objects) Console.WriteLine(obj);
//     }
// }

// class Animal {public string Name { get; set; }}
//
// class Dog : Animal
// {
//     public void Bark() => Console.WriteLine("Woof");
// }
//
// class Program
// {
//     static void Main()
//     {
//         Func<Dog> dogFunc = () => new Dog { Name = "Rex" };
//         Func<Animal> animalFunc = dogFunc;
//
//         Animal animal = animalFunc();
//         Console.WriteLine(animal.Name);
//     }
// }

// List<Dog> dogs = new List<Dog>();
// List<Animal> animals = dogs;
//
// class Animal {}
// class Dog : Animal {}

