using System;
using System.Reflection;

namespace Reflections
{
    class Program
    {
        static void Main(string[] args)
        {
            // DortIslem dortIslem = new DortIslem(2,3);
            // System.Console.WriteLine(dortIslem.Topla2());
            // System.Console.WriteLine(dortIslem.Topla(3,4));

            var type = typeof(DortIslem);
            // DortIslem dortIslem = (DortIslem)Activator.CreateInstance(type,2,3);
            // System.Console.WriteLine(dortIslem.Topla(3,5));
            // System.Console.WriteLine(dortIslem.Topla2());

            var instance = Activator.CreateInstance(type,6,5);
            
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");

            foreach (var method in instance.GetType().GetMethods())
            {
                System.Console.WriteLine("Metot adı : " + method.Name);
                    foreach (var parameter in method.GetParameters())
                    {
                        System.Console.WriteLine("Parametre : {0}",parameter.Name);
                    }

                foreach (var attribute in method.GetCustomAttributes())
                {
                    System.Console.WriteLine("Attribute adı : ",attribute.GetType().Name);
                }
            }

            System.Console.WriteLine(methodInfo.Invoke(instance,null));
        }
    }

    public class DortIslem{
        private int _sayi1;
        private int _sayi2;
        public DortIslem(int sayi1,int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
        public int Topla(int sayi1,int sayi2){
            return sayi1+sayi2;
        }

        public int Carp(int sayi1,int sayi2){
            return sayi1*sayi2;
        }

        public int Topla2(){
            return _sayi1+_sayi2;
        }

        public int Carp2(){
            return _sayi1*_sayi2;
        }
    }
}
