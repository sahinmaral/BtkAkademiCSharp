using System;

namespace Adapter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new Log4NetAdapter());
            productManager.Save();
        }
    }

    class ProductManager
    {
        private ILogger _logger;

        public ProductManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Save()
        {
            _logger.Log("User Data");
            Console.WriteLine("Product saved");
        }
    }

    class Log4NetAdapter : ILogger
    {
        public void Log(string message)
        {
            Log4Net log4Net = new Log4Net();
            log4Net.LogMessage(message);
        }
    }

    interface ILogger
    {
        void Log(string message);
    }

    class LogNewLogger:ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Logged , {0}",message);
        }
    }

    //Dokunulamıyor
    class Log4Net
    {
        public void LogMessage(string message)
        {
            Console.WriteLine("Logged with log4net, {0}", message);
        }
    }
}