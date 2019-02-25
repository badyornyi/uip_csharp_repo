using System;

namespace BAL.UIP.FirstClass.FirstApp.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int rectangleSideA = 30;
            //int rectangleSideB = 40;

            //int rectangleSquare = rectangleSideA * rectangleSideB;
            //int rectanglePerimeter = 2 * rectangleSideA + 2 * rectangleSideB;

            //int i = 0;
            //int i1 = i--;
            //Console.WriteLine(i1);
            //Console.WriteLine(i);
            //int i2 = --i;
            //Console.WriteLine(i2);



            //Console.WriteLine(rectangleSquare);
            //Console.WriteLine(rectanglePerimeter);
            //Console.WriteLine(i1);
            //Console.WriteLine(i2);
            //Console.ReadLine();

            int personAge = 19;

            bool isAlcoholSaleRestricted = personAge < 21;
            Console.WriteLine("Alcohol sale restricted: " + isAlcoholSaleRestricted);
            Console.ReadLine();

        }
    }
}
