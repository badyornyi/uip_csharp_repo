using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.UIP.HW4.OOP.Classes.TaskTwoConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomizer = new Random();

            int detailsCountInAggregate = randomizer.Next(10, 30);
            int workersInvolvedToAssembly = randomizer.Next(2, 8);

            Aggregate aggregate = new Aggregate(detailsCountInAggregate, workersInvolvedToAssembly);

            aggregate.PeopeWorkingOnAggregate();
            aggregate.AssembleAggregate();

            Console.ReadLine();
        }
    }

    class Worker
    {
        public Worker(string name, int skillLevel)
        {
            this.WorkerName = name;
            this.SkillLevel = skillLevel;
        }

        public string WorkerName { get; set; }
        private int _SkillLevel;
        public int SkillLevel {
            private get
            {
                return this._SkillLevel;
            }
            set
            {
                if (value > 3 || value < 1)
                {
                    Console.WriteLine($"Incorrect Skill Level: '{value}'. Please, enter Skill level: 1 (Junior), 2 (Middle), 3 (Senior)");
                    return;
                }
                this._SkillLevel = value;
            }
        }

        public string GetWorkerInfo()
        {
            string skillLevel = "";

            switch (this.SkillLevel)
            {
                case 1:
                    {
                        skillLevel = "Junior";
                        break;
                    }
                case 2:
                    {
                        skillLevel = "Middle";
                        break;
                    }
                case 3:
                    {
                        skillLevel = "Senior";
                        break;
                    }
                default:
                    {
                        skillLevel = "Unskilled";
                        break;
                    }
            }
            string workerInfo = this.WorkerName + ", " + skillLevel;
            return workerInfo;
        }

        public int GetSkillMultiplier()
        {
            int skillMultiplier = 0;
            switch (this.SkillLevel)
            {
                case 1: { skillMultiplier = 1; break; }
                case 2: { skillMultiplier = 3; break; }
                case 3: { skillMultiplier = 5; break; }
                default: { skillMultiplier = 0; break; }
            }
            return skillMultiplier;
        }
    }

    class Aggregate
    {
        public Aggregate(int detailsCount, int workersCount)
        {
            this.DetailsCount = detailsCount;
            this.Workers = new Worker[workersCount];

            InitializeWorkers();
        }

        public Worker[] Workers { get; set; }
        public int DetailsCount { get; set; }

        Random randomizer = new Random();

        private void InitializeWorkers()
        {
            for (int i = 0; i < Workers.Length; i++)
            {
                string name = "Worker_" + randomizer.Next(10, 50).ToString();
                int skill = randomizer.Next(1, 4);
                this.Workers[i] = new Worker(name, skill);
            }
        }

        public void PeopeWorkingOnAggregate()
        {
            Console.WriteLine("Today on duty:");
            int workersCount = this.Workers.Length;
            for (int i = 0; i < workersCount; i++)
            {
                Console.WriteLine(i + 1 + ". " + this.Workers[i].GetWorkerInfo());
            }
            Console.WriteLine();
        }

        public void AssembleAggregate()
        {
            int assembledDetails = 0;

            Console.WriteLine($"Aggregate should contain {this.DetailsCount} details.");
            Console.WriteLine("Aggregate assembly started");
            Console.WriteLine("==");
            while (assembledDetails < this.DetailsCount)
            {
                for (int i = 0; i < this.Workers.Length; i++)
                {
                    int skillMultiplier = Workers[i].GetSkillMultiplier();

                    if (assembledDetails >= this.DetailsCount)
                    {
                        break;
                    }

                    if (this.DetailsCount - assembledDetails < skillMultiplier)
                    {
                        continue;
                    }

                    string workerAddsDetails = $"{Workers[i].WorkerName} adds {skillMultiplier} detail(s)";
                    Console.WriteLine($"||\t" + workerAddsDetails);
                    if (skillMultiplier == 3 || skillMultiplier == 5)
                    {
                        Console.WriteLine("||");
                        Console.WriteLine("||");
                    }
                    if (skillMultiplier == 5)
                    {
                        Console.WriteLine("||");
                        Console.WriteLine("||");
                    }

                    assembledDetails += skillMultiplier;
                }
            }
            Console.WriteLine("==");
            Console.WriteLine("Aggregate assembly finished");
        }
    }
}
