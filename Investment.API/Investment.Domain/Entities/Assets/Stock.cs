using Investment.Domain.Base;

namespace Investment.Domain.Entities.Assets
{
    public class Stock : BaseEntity
    {
        public string CompanyName { get; set; }
        public int InvestorId { get; set; }
        public int NumberOfShares { get; set; }
        public decimal SharePrice { get; set; }
        public string Notes { get; set; }
    }
}
