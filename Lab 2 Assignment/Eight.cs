using System;
namespace Lab28
{
    abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract void MakeSound();
    }

    class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the dog is barking");
        }

        public void Fetch()
        {
            Console.WriteLine($"{Name} is fetching the ball.");
        }
    }

    class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the cat says meow!");
        }

        public void Purr()
        {
            Console.WriteLine($"{Name} is purring.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Buddy", 3);
            dog.MakeSound();
            dog.Fetch();

            Cat cat = new Cat("Whiskers", 5);
            cat.MakeSound();
            cat.Purr();
        }
    }
}
