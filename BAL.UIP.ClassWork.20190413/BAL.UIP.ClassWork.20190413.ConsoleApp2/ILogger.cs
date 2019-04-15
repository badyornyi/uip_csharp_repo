namespace BAL.UIP.ClassWork._20190413.ConsoleApp2
{
    public interface ILogger
    {
        void Info(string message);
        void Warn(string message);
        void Error(string message);
        void Debug(string message);
        void Fatal(string message);
    }
}
