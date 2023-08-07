using Investment.Domain.Base;
using Investment.Domain.Enums;

namespace Investment.Domain.Entities.Assets
{
    public class AgriCultureProperty : BaseEntity
    {
        public AgriCultureProperty()
        {
            PropertyType = PropertyType.Agriculture;
        }

        public string ReferenceNumber { get; set; }
        public DateOnly DateOfPurchase { get; set; }
        public string PropertyName { get; set; }
        public PropertyType PropertyType { get; set; }
        public AgriculturePropertyDetail PropertyDetail { get; set; }
        public string Location { get; set; }
        public int OwnerId { get; set; }
        public decimal CurrentMarketValue { get; set; }
        public DateOnly MarketValueDate { get; set; }
        public string Notes { get; set; }
    }
}
