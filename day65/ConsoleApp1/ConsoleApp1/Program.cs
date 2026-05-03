// using System.Runtime.CompilerServices;
//
// class Program
// {
//     // static void DuplicateRemove(int[] nums)
//     // {
//     //     int slow = 0;
//     //     for (int fast = 1; fast < nums.Length; fast++)
//     //     {
//     //         if (nums[slow] != nums[fast]) 
//     //         {
//     //             slow++;
//     //             nums[slow] = nums[fast];
//     //         }
//     //     }
//     //
//     //     for (int i = slow + 1; i < nums.Length; i++) nums[i] = 0;
//     // }
//     //
//     // static void Main()
//     // {
//     //      int[] a = new int[] { 1, 1, 2 };
//     //     DuplicateRemove(a);
//     //     Console.WriteLine(string.Join(", ", a));
//     //     
//     // }
//
//     static void RemoveElement(int[] nums, int val)
//     {
//         int slow = 0;
//         for (int fast = 1; fast < nums.Length; fast++)
//         {
//             if (nums[fast] != val)
//             {
//                 nums[slow] = nums[fast];
//                 slow++;
//             }
//         }
//
//         for (int i = slow; i < nums.Length; i++) nums[i] = 0;
//         // return slow;
//     }
//
//     static void Main()
//     {
//         int[] nums = new int[] { 3, 2, 2, 3 };
//         RemoveElement(nums, 3);
//         Console.WriteLine(string.Join(", ", nums));
//
//         // Console.WriteLine(string.Join(", ", nums));
//
//     }
// }


// class Animal { public string Name; }
// class Dog : Animal {}
//
// class AnimalComparer : IComparer<Animal>
// {
//     public int Compare(Animal x, Animal y) => x.Name.Length.CompareTo(y.Name.Length);
// }
//
// class Program
// {
//     static void Main()
//     {
//         IComparer<Animal> animalComparer = new AnimalComparer();
//         IComparer<Dog> dogComparer = animalComparer;
//         Console.WriteLine("Ishladi");
//     }
// }

// ========= COVARIANCE ============

// public class Animal
// {
//     public string Name { get; set; }
// }
// public class Dog : Animal { }
//
// public interface IProducer<out T>
// {
//     T Get();
// }
//
// public class DogProducer : IProducer<Dog>
// {
//     public Dog Get()
//     {
//         return new Dog() { Name = "Rex" };
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         IProducer<Dog> dogProducer = new DogProducer();
//         IProducer<Animal> animalProducer = dogProducer;
//
//         Animal animal = animalProducer.Get();
//         Console.WriteLine(animal.Name);
//     }
// }

// ============ CONTRAVARIANCE =============
// public class Animal
// {
//     public string Name { get; set; }
// }
//
// public class Dog : Animal{}
//
// public interface IConsumer<in T>
// {
//     void Consume(T item);
// }
//
// public class AnimalConsumer : IConsumer<Animal>
// {
//     public void Consume(Animal item) => Console.WriteLine(item.Name);
// }

// class Program
// {
//     static void Main()
//     {
//         IConsumer<Animal> animalConsumer = new AnimalConsumer();
//         IConsumer<Dog> dogConsumer = animalConsumer;
//         dogConsumer.Consume(new Dog() {Name = "Rex"});
//     }
// }

using System.Collections;

// class Animal
// {
//     public string Name { get; set; }
// }
//
//  class Dog : Animal
//  {
//      public void Woof() => Console.WriteLine("Woof");
//  }
//
//  interface IFactory<out T>
//  {
//      T Create();
//  }
//
//  class DogFactory : IFactory<Dog>
//  {
//      public Dog Create()
//      {
//          return new Dog() { Name = "Rex" };
//      }
//  }
//
//  class Program
//  {
//      static void Main()
//      {
//          IFactory<Dog> dogFactory = new DogFactory();
//          IFactory<Animal> animalFactory = dogFactory;
//
//          Animal animal = animalFactory.Create();
//          Console.WriteLine(animal.Name);
//      }
//  }

// class Animal
// {
//     public string Name { get; set; }
// }
//
// class Dog : Animal{}
//
// public interface IConsumer<in T>
// {
//     void Consume(T item);
// }
//
// class AnimalConsumer : IConsumer<Animal>
// {
//     public void Consume(Animal item)
//     {
//         Console.WriteLine($"Consumed: {item}");
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         IConsumer<Animal> animalConsumer = new AnimalConsumer();
//         IConsumer<Dog> dogConsumer = animalConsumer;
//         dogConsumer.Consume(new Dog() {Name = "Rex"});
//     }
// }

// class Animal
// {
//     public string Name { get; set; }
// }
//
// class Dog : Animal { }
//
// class Program
// {
//     static void Main()
//     {
//         // List<Dog> dogs = new List<Dog>()
//         // {
//         //     new Dog() {Name = "Rex"}
//         // };
//         List<Animal> animals = new List<Animal>();
//         animals.Add(new Dog() {Name = "Rex"});
//         animals.Add(new Dog() {Name = "gATTO"});
//
//         foreach (var a in animals)
//         {
//             Console.WriteLine(a.Name);
//         }
//     }
// }

// Covariance
// class Animal
// {
//     public string Name { get; set; }
// }
//
// class Dog : Animal {}
//
// interface IProduce<out T>
// {
//     T Produce();
// }
//
// class DogProduce : IProduce<Dog>
// {
//     public Dog Produce()
//     {
//         return new Dog() { Name = "Rex" };
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         IProduce<Dog> dogProduce = new DogProduce();
//         IProduce<Animal> animalProduce = dogProduce;
//         Animal animal = dogProduce.Produce();
//         Console.WriteLine(animal.Name);
//     }
// }

// 2. Contravariance
// class Animal
// {
//     public string Name { get; set; }
// }
//
// class Dog : Animal {}
//
// interface IConsume<in T>
// {
//     void Consume(T item);
// }
//
// class AnimalConsume : IConsume<Animal>
// {
//     public void Consume(Animal item)
//     {
//         Console.WriteLine(item.Name);
//     }
// }
//
// class Program
// {
//     static void Main()
//     {
//         IConsume<Animal> animalConsume = new AnimalConsume();
//         IConsume<Dog> dogConsume = animalConsume;
//         dogConsume.Consume(new Dog() {Name = "Rex"});
//     }
// }

// class Animal
// {
//     public string Name { get; set; }
// }
//
// class Dog : Animal {}
//
// class Program
// {
//     static void Main()
//     {
//         List<Dog> dog = new List<Dog>()
//         {
//             new Dog { Name = "Rex" }
//         };
//         // List<Dog> dogs = new List<Dog>();
//         // XATO
//         // List<Animal> animals = dogs;
//         List<Animal> animals = new List<Animal>();
//         animals.Add(new Dog() {Name = "Rex"});
//         foreach (var animal in animals)
//         {
//             Console.WriteLine(animal.Name);
//         }
//
//     }
// }

// class Animal
// {
//     public string Name { get; set; }
// }
//
// class Dog : Animal {}
//
// public interface IBox<T>
// {
//     T Get();
//     void Set(T item);
// }
//
// class DogBox : IBox<Dog>
// {
//     private Dog _dog;
//     public Dog Get() => _dog;
//     public void Set(Dog item) => _dog = item;
// }
//
// class Program
// {
//     static void Main()
//     {
//         IBox<Dog> dogBox = new DogBox();
//         
//         dogBox.Set(new Dog{Name = "rex"});
//         Dog dog = dogBox.Get();
//         Console.WriteLine(dog.Name);
//     }
// }