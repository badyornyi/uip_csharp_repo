using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// using interfaces (IComparable)
namespace BAL.UIP.ClassWork._20190413.ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Human> employees = new List<Human>()
            {
                new Plumber("Alexandr"),  // 1
                new Plumber("Alexandra"), // 2
                new Accounter("Nadya"),   // 4
                new Accounter("Dasha")    // 3
            };

            employees.Sort();
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Name);
            }

            Console.ReadLine();
        }
    }

    public abstract class Human : IComparable
    {
        public string Name { get; set; }

        public Human(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return this.Name;
        }

        public int CompareTo(object obj)
        {
            Human human = obj as Human;
            if (human == null)
            {
                return 1;
            }

            return this.Name.CompareTo(human.Name);
        }
    }

    public class Plumber : Human
    {
        public Plumber(string name) : base(name) { }
    }

    public class Accounter : Human
    {
        public Accounter(string name) : base(name) {}
    }


}
