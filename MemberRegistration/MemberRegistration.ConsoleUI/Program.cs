using DevFramework.Northwind.Business.DependencyResolvers.Ninject;

using MemberRegistration.Business.Abstract;
using MemberRegistration.Entities.Concrete;

using System;

namespace MemberRegistration.ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var memberService = InstanceFactory.GetInstance<IMemberService>();
            memberService.Add(
                new Member
                {
                    FirstName = "Şahin",
                    LastName = "Maral",
                    DateOfBirth = new DateTime(2000,02,11),
                    TCNo = "00000000000",
                    Email = "sahin.maral@hotmail.com"
                });

            Console.WriteLine("Eklendi");
            Console.ReadLine();
        }
    }
}
