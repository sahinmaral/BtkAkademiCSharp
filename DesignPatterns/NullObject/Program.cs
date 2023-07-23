namespace NullObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new Log4NetLogger());
            customerManager.Save();

            Console.WriteLine("-------------------");

            CustomerManagerTests tests = new CustomerManagerTests();
            tests.Test();

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        private ILogger _logger;

        public CustomerManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Save()
        {
            Console.WriteLine("Business codes of saving customer");
            _logger.Log();
        }
    }

    interface ILogger 
    {
        void Log();
    }
    class Log4NetLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with Log4Net");
        }
    }

    class NLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with NLogger");
        }
    }

    class StubLogger : ILogger
    {
        private static StubLogger _stubLogger;
        private static object _lock = new object();

        private StubLogger() { }

        public static StubLogger GetLogger()
        {
            lock (_lock)
            {
                if (_stubLogger == null)
                {
                    _stubLogger = new StubLogger();
                }
                return _stubLogger;
            }
        }

        public void Log()
        {

        }
    }

    class CustomerManagerTests
    {
        public void Test()
        {
            //Sadece save metodunun calisip calismadigini test etmek istiyoruz.
            //Fakat DI dizaynini kullandigimiz zaman log lama da kullanmis olacagiz
            CustomerManager customerManager = new CustomerManager(StubLogger.GetLogger());
            customerManager.Save();
        }
    }
}