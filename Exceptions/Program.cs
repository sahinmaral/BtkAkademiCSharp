using System;
using System.Collections.Generic;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionDemo();

            
            HandleException(()=>{
                Find();
            });

        }

        private static void HandleException(Action action)
        {
            try
            {
                 action.Invoke();
            }
            catch (System.Exception exception)
            {
                System.Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> students = new List<string>() { "Engin", "Derin", "Salih" };

            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record Not Found");
            }
            else
            {
                System.Console.WriteLine("Record Found!");
            }
        }

        private static void ExceptionDemo()
        {
            try
            {
                string[] students = new string[3] { "Engin", "Derin", "Şahin" };
                students[3] = "Ahmet";
            }
            catch (System.IndexOutOfRangeException exception)
            {
                System.Console.WriteLine(exception.Message);
            }
        }
    }
}
