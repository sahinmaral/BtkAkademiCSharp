using System;

namespace DelegatesDemo
{
    class Program
    {
        public delegate void MyDelegate();
        public delegate void MyDelegate2(string text);
        
        
        static void Main(string[] args)
        {
            //Delegate1();

            //Delegate2();

            Func<int, int, int> add = Topla;

            Console.WriteLine(add(1,2));

            Func<int> getRandomNumber = delegate()
            {
                Random random = new Random();
                return random.Next(0, 100);
            };

            Func<int> getRandomNumber2 = () => new Random().Next(0, 100);

            Console.WriteLine(getRandomNumber());

            Console.ReadLine();
        }

        static int Topla(int x, int y)
        {
            return x + y;
        }

        private static void Delegate2()
        {
            TestClass customerManager = new TestClass();

            MyDelegate2 myDelegate2 = customerManager.Test11;

            myDelegate2.Invoke("Text");
        }

        private static void Delegate1()
        {
            TestClass customerManager = new TestClass();

            MyDelegate myDelegate = customerManager.Test1;

            myDelegate += customerManager.Test2;

            myDelegate.Invoke();

            Console.WriteLine("------------");

            myDelegate -= customerManager.Test1;

            myDelegate.Invoke();
        }
    }

    public class TestClass
    {
        public void Test1()
        {
            Console.WriteLine("Test1");
        }

        public void Test11(string text)
        {
            Console.WriteLine("Test " + text);
        }

        public void Test2()
        {
            Console.WriteLine("Test2");
        }

        public void Test22(string text)
        {
            Console.WriteLine("Test2 " + text );
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}
