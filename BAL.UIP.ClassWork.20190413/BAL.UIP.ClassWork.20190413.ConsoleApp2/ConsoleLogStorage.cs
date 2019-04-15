using System;

namespace BAL.UIP.ClassWork._20190413.ConsoleApp2
{
    public class ConsoleLogStorage : ILogStorage
    {
        public void WriteLog(string message)
        {
            Console.WriteLine($"{this.GetType().Name}: {message}");
        }
    }
}
