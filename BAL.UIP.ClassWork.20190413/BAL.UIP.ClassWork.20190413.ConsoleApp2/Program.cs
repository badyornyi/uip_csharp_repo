using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BAL.UIP.ClassWork._20190413.ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            logger.LogLevel = 4;
            logger.Info("User logged out1");
            logger.Debug("User logged out1");
            logger.Warn("User logged out1");
            logger.Error("User logged out1");
            logger.Fatal("User logged out1");
            logger.LogStorages.Add(new ConsoleLogStorage());
            logger.LogStorages.Add(new TextFileLogStorage());
            logger.Info("User logged out2");
            logger.Debug("User logged out2");
            logger.Warn("User logged out2");
            logger.Error("User logged out2");
            logger.Fatal("User logged out2");
            logger.LogStorages.RemoveAt(1);
            Console.WriteLine("LogLevel 1");
            logger.LogLevel = 1;
            logger.Debug("User logged out3");
            logger.Warn("User logged out3");
            logger.Error("User logged out3");
            logger.Fatal("User logged out3");
            logger.Info("User logged out3");

            Console.ReadLine();
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static string GetMethodName()
        {
            StackFrame sf = new StackTrace().GetFrame(1);
            return sf.GetMethod().Name;
        }
    }
}
