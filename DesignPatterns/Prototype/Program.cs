using System;

namespace Prototype
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
                FirstName = "Şahin",
                LastName = "MARAL",
                City = "İstanbul",
                Id = 1
            };

            Console.WriteLine(customer1.City);

            Customer customer2 = (Customer)customer1.Clone();

            customer2.City = "Ankara";
            
            Console.WriteLine(customer2.City);
        }
    }

    public abstract class Person
    {
        public abstract Person Clone();
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Customer : Person
    {
        public string City { get; set; }

        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }

    public class Employee : Person
    {
        public decimal Salary { get; set; }

        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }
}