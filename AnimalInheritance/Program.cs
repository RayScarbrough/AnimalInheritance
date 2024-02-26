using System;

namespace AnimalInheritance
{
    // Base Class
    class Animal
    {
        private string name; // only accessible within this class
        protected string type; // accessible from derived classes
        public string color; // accessible from any class

        public void setName(string name)
        {
            this.name = name;
        }
        public virtual string getName()
        {
            return this.name;
        }
        public void setType(string type)
        {
            this.type = type;
        }
        public virtual string getType()
        {
            return this.type;
        }
    }

    // Derived Class
    class Cat : Animal
    {
        public string breed; 
        private int age; 
        protected bool isIndoor; 

        public void setAge(int age)
        {
            this.age = age;
        }
        public int getAge()
        {
            return this.age;
        }

        public void setIsIndoor(bool isIndoor)
        {
            this.isIndoor = isIndoor;
        }
        public bool getIsIndoor()
        {
            return this.isIndoor;
        }

        
        public override string getName()
        {
            return base.getName();
        }

        
        public override string getType()
        {
            return base.getType();
        }

      
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Using the base class
            Animal animal = new Animal();
            animal.setName("Leo");
            animal.setType("Lion");
            animal.color = "Golden";
            Console.WriteLine($"Name: {animal.getName()}");
            Console.WriteLine($"Animal: {animal.getType()}");
            Console.WriteLine($"Color: {animal.color}");
            Console.WriteLine();

            // Using the derived class
            Cat cat = new Cat();
            cat.setName("Whiskers");
            cat.setType("Tabby");
            cat.color = "Gray";
            cat.breed = "British Shorthair";
            cat.setAge(3);
            cat.setIsIndoor(true);
            Console.WriteLine($"Name: {cat.getName()}");
            Console.WriteLine($"Animal: {cat.breed} {cat.getType()}");
            Console.WriteLine($"Color: {cat.color}");
            Console.WriteLine($"Age: {cat.getAge()}");
            Console.WriteLine($"Indoor: {cat.getIsIndoor()}");
            
        }
    }
}