using System;

namespace Facade
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Save();
        }
    }

    class Logging : ILogging
    {
        public void Log()
        {
            Console.WriteLine("Logged");
        }
    }

    internal interface ILogging
    {
        void Log();
    }

    class Caching : ICaching
    {
        public void Cache()
        {
            Console.WriteLine("Cached");
        }
    }

    internal interface ICaching
    {
        void Cache();
    }

    class Authorize : IAuthorize
    {
        public void CheckUser()
        {
            Console.WriteLine("User checked");
        }
    }

    internal interface IAuthorize
    {
        void CheckUser();
    }


    class CustomerManager
    {
        private CrossCuttingConcernsFacade _concerns;

        public CustomerManager()
        {
            _concerns = new CrossCuttingConcernsFacade();
        }

        public void Save()
        {
            _concerns._logging.Log();
            _concerns._caching.Cache();
            _concerns._authorize.CheckUser();
            _concerns._validating.Validate();
            Console.WriteLine("Saved");
        }
    }

    public class Validating:IValidating
    {
        public void Validate()
        {
            Console.WriteLine("Validated");
        }
    }

    public interface IValidating
    {
        void Validate();
    }

    class CrossCuttingConcernsFacade
    {
        public ILogging _logging;
        public ICaching _caching;
        public IAuthorize _authorize;
        public IValidating _validating;
        public CrossCuttingConcernsFacade()
        {
            _validating = new Validating();
            _logging = new Logging();
            _caching = new Caching();
            _authorize = new Authorize();
        }
    }
}