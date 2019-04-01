using System;
using System.Collections.Generic;

namespace BAL.UIP.ClassWork._20190330.ConsoleApp
{
    public class Order
    {
        public Guid OrderNumber { get; set; }
        public List<Tank> Tanks { get; set; }
        public List<Car> Cars { get; set; }
        public bool IsCompleted { get; } //TODO

        public Order()
        {
            this.OrderNumber = Guid.NewGuid();
        }
    }
}