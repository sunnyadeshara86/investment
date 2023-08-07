using Investment.Domain.Base;
using Investment.Domain.Enums;
using Investment.Domain.ValueObjects;

namespace Investment.Domain.Entities.Core
{
    public class Person : BaseEntity
    {
        public string PersonType { get; set; }
        public string PAN { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public string Occupation { get; set; }
        public string Company { get; set; }
        public Address Address { get; set; }
        public CommunicationInfo CommunicationInfo { get; set; }
    }
}
