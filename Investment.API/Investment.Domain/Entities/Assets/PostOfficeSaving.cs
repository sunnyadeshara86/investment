using Investment.Domain.Base;
using Investment.Domain.Enums;

namespace Investment.Domain.Entities.Assets
{
    public class PostOfficeSaving : BaseEntity
    {
        public string CustomerId { get; set; }
        public string AccountNumber { get; set; }
        public int OrganizationId { get; set; }
        public int InvestorId { get; set; }
        public InvestmentMode InvestmentMode { get; set; }
        public decimal AmountInvested { get; set; }
        public decimal RateOfInterest { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public decimal FundValue { get; set; }
        public DateOnly FundValueDate { get; set; }
        public string Notes { get; set; }
    }
}
