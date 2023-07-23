using System;
using System.Threading;

namespace Proxy
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CreditBase creditManager = new CreditManagerProxy();
            Console.WriteLine(creditManager.Calculate());
            Console.WriteLine(creditManager.Calculate());

            Console.ReadLine();
        }
    }

    abstract class CreditBase
    {
        public abstract int Calculate();
    }

    class CreditManagerProxy:CreditBase
    {
        private CreditManager _creditManager;
        private int _cachedValue;
        public override int Calculate()
        {
            if (_creditManager == null)
            {
                _creditManager = new CreditManager();
                _cachedValue = _creditManager.Calculate();
            }

            return _cachedValue;

        }
    }

    class CreditManager : CreditBase
    {
        public override int Calculate()
        {
            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result = result * i;
                Thread.Sleep(1000);
            }

            return result;
        }
    }
}