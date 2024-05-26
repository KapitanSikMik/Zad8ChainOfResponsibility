using System;

namespace Zadanie_8___Chain_of_Responsibility
{

        public abstract class Logger
        {
            protected Logger nextLogger;

            public void SetNextLogger(Logger nextLogger)
            {
                this.nextLogger = nextLogger;
            }

            public void LogMessage(LogLevel level, string message)
            {
                if (this.CanHandle(level))
                {
                    this.Write(message);
                }
                else if (nextLogger != null)
                {
                    nextLogger.LogMessage(level, message);
                }
            }

            protected abstract bool CanHandle(LogLevel level);
            protected abstract void Write(string message);
        }

        public enum LogLevel
        {
            INFO,
            WARNING,
            ERROR
        }

        public class InfoLogger : Logger
        {
            protected override bool CanHandle(LogLevel level)
            {
                return level == LogLevel.INFO;
            }

            protected override void Write(string message)
            {
                Console.WriteLine("INFO: " + message);
            }
        }

        public class WarningLogger : Logger
        {
            protected override bool CanHandle(LogLevel level)
            {
                return level == LogLevel.WARNING;
            }

            protected override void Write(string message)
            {
                Console.WriteLine("OSTRZEŻENIE: " + message);
            }
        }

        public class ErrorLogger : Logger
        {
            protected override bool CanHandle(LogLevel level)
            {
                return level == LogLevel.ERROR;
            }

            protected override void Write(string message)
            {
                Console.WriteLine("BŁĄD: " + message);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Logger infoLogger = new InfoLogger();
                Logger warningLogger = new WarningLogger();
                Logger errorLogger = new ErrorLogger();

                infoLogger.SetNextLogger(warningLogger);
                warningLogger.SetNextLogger(errorLogger);

                Logger loggerChain = infoLogger;

                loggerChain.LogMessage(LogLevel.INFO, "To jest wiadomość informacyjna.");
                loggerChain.LogMessage(LogLevel.WARNING, "To jest wiadomość ostrzegawcza.");
                loggerChain.LogMessage(LogLevel.ERROR, "To jest wiadomość o błędzie.");
            }
        }
    }

