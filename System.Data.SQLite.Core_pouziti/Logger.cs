using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Data.SQLite.Hepipet
{
    enum LogLevel
    {
        Vytvoření,
        Potvrzení,
        Zrušení
    }

    interface ILogger
    {
        void Log(LogLevel level, string text);
    }

    class ConsoleLogger : ILogger
    {
        private int counter;
        public ConsoleLogger()
        {
            counter = 0;
        }
        public void Log(LogLevel level, string message)
        {
            //System.Diagnostics.Trace.WriteLine($"{counter} {level} {DateTime.Now}: {message}");
            //Console.WriteLine($"{counter} {level} {DateTime.Now}: {message}");
            System.Diagnostics.Debug.WriteLine($"{counter} {level} {DateTime.Now}: {message}");
            ++counter;
        }
    }

    class FileLogger : ILogger
    {
        private int counter;
        public FileLogger()
        {
            counter = 0;
        }
        public void Log(LogLevel level, string message)
        {
            System.IO.File.AppendAllText("log.txt", $"{counter} {level} {DateTime.Now}: {message}" + Environment.NewLine);
            ++counter;
        }
    }
}
