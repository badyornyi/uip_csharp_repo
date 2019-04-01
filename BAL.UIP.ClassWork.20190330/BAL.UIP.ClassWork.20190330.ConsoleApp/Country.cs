﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.UIP.ClassWork._20190330.ConsoleApp
{
    class Country
    {
        public string Name { get; private set; }

        public Country(string name)
        {
            this.Name = name;
        }

        public List<Order> GenerateNewOrders(int ordersCount)
        {
            if (ordersCount <= 0)
            {
                Console.WriteLine($"Invalis orders count: '{ordersCount}'");
                return null;
            }

            Random randomizer = new Random();

            List<Order> orders = new List<Order>();

            for (int i = 0; i < ordersCount; i++)
            {
                orders.Add(GenerateNewOrder(randomizer));
            }
            return orders;
        }

        private Order GenerateNewOrder(Random randomizer)
        {
            Order newOrder = new Order();
            newOrder.Tanks = new List<Tank>();
            newOrder.Cars = new List<Car>();

            int tanksCount = randomizer.Next(1, 10);
            for (int j = 0; j < tanksCount; j++)
            {
                newOrder.Tanks.Add(new Tank());
            }

            int carsCount = randomizer.Next(1, 10);
            for (int j = 0; j < carsCount; j++)
            {
                newOrder.Cars.Add(new Car());
            }

            return newOrder;
        }

        internal static List<Worker> HireWorkers(int v)
        {
            return new List<Worker>(); //TODO
        }
    }
}