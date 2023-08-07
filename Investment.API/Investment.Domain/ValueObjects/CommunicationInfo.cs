using Investment.Domain.Base;

namespace Investment.Domain.ValueObjects
{
    public class CommunicationInfo : ValueObject
    {
        public string PhoneNumber { get; set; }
        public string AlternatePhoneNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}
