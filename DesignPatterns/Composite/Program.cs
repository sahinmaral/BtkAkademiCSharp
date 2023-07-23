using System;
using System.Collections;
using System.Collections.Generic;

namespace Composite
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Employee masterEmployee = new Employee
            {
                Name = "Şahin MARAL"
            };

            Employee employee1 = new Employee
            {
                Name = "Ali MARAL"
            };
            
            masterEmployee.AddSubOrdinate(employee1);

            Employee employee2 = new Employee();
            
            masterEmployee.AddSubOrdinate(employee2);
        }

        interface IPerson
        {
             string Name { get; set; }
        }

        class Person : IPerson
        {
            public string Name { get; set; }
        }
        
        class Employee : IPerson,IEnumerable<IPerson>
        {
            private List<IPerson> _subordinates = new List<IPerson>();

            public void AddSubOrdinate(IPerson person)
            { 
                _subordinates.Add(person);
            }
            
            public void RemoveSubOrdinate(IPerson person)
            { 
                _subordinates.Remove(person);
            }

            public IPerson GetSubOrdinate(int index)
            {
                return _subordinates[index];
            }
            
            public string Name { get; set; }
            public IEnumerator<IPerson> GetEnumerator()
            {
                foreach (var subordinate in _subordinates)
                {
                    yield return subordinate;
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }
}