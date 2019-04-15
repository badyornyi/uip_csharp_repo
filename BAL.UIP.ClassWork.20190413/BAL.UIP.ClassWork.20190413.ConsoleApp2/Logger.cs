using System;
using System.Collections.Generic;

namespace BAL.UIP.ClassWork._20190413.ConsoleApp2
{
    public class Logger : ILogger
    {
        public List<ILogStorage> LogStorages { get; } = new List<ILogStorage>();

        private int _LogLevel;
        public int LogLevel
        {
            get
            {
                return this._LogLevel;
            }
            set
            {
                if (value < 1 || value > 5)
                {
                    return;
                }
                this._LogLevel = value;
            }
        }

        public void Debug(string message)
        {
            WriteLogToStorage(2, Program.GetMethodName(),message);
        }

        public void Error(string message)
        {
            WriteLogToStorage(4, Program.GetMethodName(), message);
        }

        public void Fatal(string message)
        {
            WriteLogToStorage(5, Program.GetMethodName(), message);
        }

        public void Info(string message)
        {
            WriteLogToStorage(1, Program.GetMethodName(), message);
        }

        public void Warn(string message)
        {
            WriteLogToStorage(3, Program.GetMethodName(), message);
        }

        public void WriteLogToStorage(int logLevelInt, string logLevel, string message)
        {
            if (logLevelInt >= LogLevel)
            {
                foreach (ILogStorage logStorage in LogStorages)
                {
                    logStorage.WriteLog($"[{logLevel.ToUpper()}]: {DateTime.Now}: {message}");
                }
            }
        }
    }
}
