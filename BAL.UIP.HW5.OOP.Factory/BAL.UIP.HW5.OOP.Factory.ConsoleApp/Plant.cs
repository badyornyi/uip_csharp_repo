using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.UIP.HW5.OOP.Factory.ConsoleApp
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
                Order openedOrder;
                do
                {
                    openedOrder = this.GetNotCompletedOrder();
                } while (openedOrder == null);

                Tank notCompletedTank = GetNotCompletedTank(openedOrder);
                if (notCompletedTank == null)
                {
                    Car notCompletedCar = GetNotCompletedCar(openedOrder);
                    worker.AddPartsToAggregate(notCompletedCar);
                }
                else
                {
                    worker.AddPartsToAggregate(notCompletedTank);
                }
                
            }
        }

        private Car GetNotCompletedCar(Order openedOrder)
        {
            //throw new NotImplementedException();
            return null;
        }

        private Tank GetNotCompletedTank(Order openedOrder)
        {
            Tank tank = openedOrder.Tanks;
            return null;
        }

        private Order GetNotCompletedOrder()
        {
            //Order openedOrder;
            do
            {
                if (this.Orders == null)
                {
                    this.Orders = Country.GenerateNewOrders(7);
                }
                foreach (var order in this.Orders)
                {
                    if (!(order.IsCompleted))
                    {
                        return order;
                    }
                }
                //Orders = Country.GenerateNewOrders(7);
            } while (true);
        }
    }
}