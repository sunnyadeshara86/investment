using Investment.Domain.Base;
using Investment.Domain.Enums;

namespace Investment.Domain.Entities.Assets
{
    public class OtherProperty : BaseEntity
    {
        public OtherProperty()
        {
            PropertyType = PropertyType.Other;
        }

        public string ReferenceNumber { get; set; }
        public DateOnly DateOfPurchase { get; set; }
        public string PropertyName { get; set; }
        public PropertyType PropertyType { get; set; }
        public string PropertyDetail { get; set; }
        public string Location { get; set; }
        public int OwnerId { get; set; }
        public decimal CurrentMarketValue { get; set; }
        public DateOnly MarketValueDate { get; set; }
        public string Notes { get; set; }
    }
}
