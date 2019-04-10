using System;

namespace BAL.UIP.HW5.OOP.Factory.ConsoleApp
{
    public class Worker
    {
        public string Name { get; private set; }
        public string Qualification { get; }
        private int SkillLevel { get; set; }
        private int SkillMultiplier { get; }
        public int Salary { get; set; }


        public Worker(string name)
        {
            this.Name = name;
        }

        internal void AddPartsToAggregate(Car notCompletedCar)
        {
            //throw new NotImplementedException();
            return;
        }

        internal void AddPartsToAggregate(Tank notCompletedTank)
        {
            //throw new NotImplementedException();
            return;
        }
    }
}