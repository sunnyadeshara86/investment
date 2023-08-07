using Investment.Domain.Base;
using Investment.Domain.ValueObjects;

namespace Investment.Domain.Entities.Core
{
    public class Organization : BaseEntity
    {
        public string OrganizationName { get; set; }
        public Address Address { get; set; }
        public CommunicationInfo CommunicationInfo { get; set; }
    }
}
