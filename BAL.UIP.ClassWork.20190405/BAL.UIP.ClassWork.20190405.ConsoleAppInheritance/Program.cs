using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.UIP.ClassWork._20190405.ConsoleAppInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dog dog1 = new Dog("Doggy_1");
            //Cat cat1 = new Cat("Kitty_1");
            //Dog dog2 = new Dog("Doggy_2");
            //Cat cat2 = new Cat("Kitty_2");

            List<Animal> animals = new List<Animal>()
            {
                new Dog("Doggy_1"),
                new Dog("Doggy_2"),
                new Cat("Kitty_1"),
                new Cat ("Kitty_2")
            };

            foreach (var animal in animals)
            {
                //Dog castedDog = animal as Dog;
                //if (castedDog != null)
                //{
                //    castedDog.ProtectHuman();
                //}

                ////if (animal is Cat)
                //if (animal is Cat castedCat)
                //{
                //    //Cat castedCat = (Cat)animal;
                //    castedCat.MakeCatEyes();
                //}
                animal.DoSomethingSpecial();
            }

            //dog1.ProtectHuman();
            //cat1.MakeCatEyes();

            Console.ReadLine();
        }
    }

    internal class Animal
    {
        public Animal(string name)
        {
            this.Name = name;
        }

        public string Name;

        public virtual void DoSomethingSpecial()
        {
            Console.WriteLine("I am Groot");
        }
    }

    internal class Dog : Animal
    {
        public Dog(string name) : base(name)
        {

        }

        public void ProtectHuman()
        {
            Console.WriteLine($"Dog named {Name} protects human");
        }

        public override void DoSomethingSpecial()
        {
            base.DoSomethingSpecial();
            this.ProtectHuman();
        }
    }

    internal class Cat : Animal
    {
        public Cat(string name) : base(name)
        {

        }

        public void MakeCatEyes()
        {
            Console.WriteLine($"Cat named {Name} makes cat eyes");
        }

        public override void DoSomethingSpecial()
        {
            base.DoSomethingSpecial();
            this.MakeCatEyes();
        }
    }
}
