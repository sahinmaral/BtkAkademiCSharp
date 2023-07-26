using MemberRegistration.Core.Entities;

using System;

namespace MemberRegistration.Entities.Concrete
{
    public class Member : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string TCNo { get; set; }
        public string Email { get; set; }
    }
}
