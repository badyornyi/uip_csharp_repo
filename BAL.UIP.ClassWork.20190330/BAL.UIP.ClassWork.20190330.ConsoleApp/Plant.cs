using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.UIP.ClassWork._20190330.ConsoleApp
{
    class Plant
    {
        public string Name { get; private set; }
        private List<Worker> Workers { get; set; }
        private List<Order> Orders { get; set; }
        public Country Country { get; private set; }

        public Plant(string name, List<Worker> workers, Country country)
        {
            this.Name = name;
            this.Workers = workers;
            this.Country = country;
        }

        internal void StartNewWorkingYear()
        {
            for (int i = 0; i < 12; i++)
            {
                this.StartNewWorkingMonth();
            };
        }

        private void StartNewWorkingMonth()
        {
            for (int i = 0; i < 30; i++)
            {
                this.StartNewWorkingDay();
            }
        }

        private void StartNewWorkingDay()
        {
            foreach (Worker worker in this.Workers)
            {
                Order openedOrder = this.GetNotCompletedOrder();

                Tank notCompletedTank = GetNotCompletedTank();
                if (notCompletedTank == null)
                {
                    Car notCompletedCar = GetNotCompletedCar();
                    worker.AddPartsToAggregate(notCompletedCar);
                }
                else
                {
                    worker.AddPartsToAggregate(notCompletedTank);
                }
                //if openedOrder == null //TODO
            }

            //do
            //{

            //} while (true);
        }

        private Car GetNotCompletedCar()
        {
            throw new NotImplementedException();
        }

        private Tank GetNotCompletedTank()
        {
            throw new NotImplementedException();
        }

        private Order GetNotCompletedOrder()
        {
            //TODO
            //if (openedOrder == null)
            //{
            //    Orders = Country.GenerateNewOrders(7);
            //}
            return null;
        }
    }
}