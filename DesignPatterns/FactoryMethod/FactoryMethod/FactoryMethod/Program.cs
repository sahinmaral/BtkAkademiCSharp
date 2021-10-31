using System;

namespace FactoryMethod
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new LoggerFactory());
            customerManager.Save();
        }
    }

    public class CustomerManager
    {
        private readonly ILoggerFactory _loggerFactory;

        public CustomerManager(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
        }

        public void Save()
        {
            Console.WriteLine("Saved");

            ILogger logger = _loggerFactory.CreateLogger();
            logger.Log();
        }
    }

    public class LoggerFactory:ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            return new MicrosoftLogger();
        }
    }
    
    public class LoggerFactory2:ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            return new MicrosoftLogger();
        }
    }

    public interface ILoggerFactory
    {
        ILogger CreateLogger();
    }

    public interface ILogger
    {
        void Log();
    }

    public class MicrosoftLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with MicrosoftLogger");
        }
    }
}