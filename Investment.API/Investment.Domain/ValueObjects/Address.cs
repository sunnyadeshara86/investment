using Investment.Domain.Base;

namespace Investment.Domain.ValueObjects
{
    public class Address : ValueObject
    {
        public string AddressLine { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string PINCode { get; set; }
    }
}
