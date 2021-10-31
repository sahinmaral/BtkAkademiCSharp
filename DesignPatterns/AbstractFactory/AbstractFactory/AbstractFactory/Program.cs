using System;

namespace AbstractFactory
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new Factory1());
            productManager.GetAll();
        }
    }

    public class ProductManager
    {
        private CrossCuttingConcernsFactory _crossCuttingConcernsFactory;
        private Logging _logging;
        private Caching _caching;
        public ProductManager(CrossCuttingConcernsFactory crossCuttingConcernsFactory)
        {
            _crossCuttingConcernsFactory = crossCuttingConcernsFactory;
            _caching = _crossCuttingConcernsFactory.CreateCaching();
            _logging = _crossCuttingConcernsFactory.CreateLogged();
        }
        public void GetAll()
        {
            Console.WriteLine("Products listed");
            _logging.Log("message");
            _caching.Cache("data");
        }
    }

    public class Factory1 : CrossCuttingConcernsFactory
    {
        public override Logging CreateLogged()
        {
            return new Log4NetLogger();
        }

        public override Caching CreateCaching()
        {
            return new RedisCache();
        }
    }
    
    public class Factory2 : CrossCuttingConcernsFactory
    {
        public override Logging CreateLogged()
        {
            return new NLogger();
        }

        public override Caching CreateCaching()
        {
            return new MemCache();
        }
    }

    public abstract class CrossCuttingConcernsFactory
    {
        public abstract Logging CreateLogged();
        public abstract Caching CreateCaching();
    }

    public abstract class Logging
    {
        public abstract void Log(string message);
    }

    public abstract class Caching
    {
        public abstract void Cache(string data);
    }

    public class Log4NetLogger : Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine("Logged with log4net");
        }
    }
    
    public class NLogger : Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine("Logged with nLogger");
        }
    }

    public class MemCache : Caching
    {
        public override void Cache(string data)
        {
            Console.WriteLine("Cached with memCache");
        }
    }
    
    public class RedisCache : Caching
    {
        public override void Cache(string data)
        {
            Console.WriteLine("Cached with redisCache");
        }
    }
}