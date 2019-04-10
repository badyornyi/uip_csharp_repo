using System;
using System.Collections.Generic;

namespace BAL.UIP.HW5.OOP.Factory.ConsoleApp
{
    public class Order
    {
        public Guid OrderNumber { get; set; }
        public List<Tank> Tanks { get; set; }
        public List<Car> Cars { get; set; }
        public bool IsCompleted { get; private set; } //TODO

        public Order()
        {
            this.OrderNumber = Guid.NewGuid();
        }

        private bool SetOrderCompleted()
        {
            return IsCompleted = true;
        }
    }
}