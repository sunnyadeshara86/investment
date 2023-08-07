using Investment.Domain.Base;

namespace Investment.Domain.Entities.Assets
{
    public class ProvidentFund : BaseEntity
    {
        public string UAN { get; set; }
        public string PFNumber { get; set; }
        public int OrganizationId { get; set; }
        public int InvestorId { get; set; }
        public bool IsCurrent { get; set; }
        public decimal RateOfInterest { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public decimal FundValue { get; set; }
        public DateOnly FundValueDate { get; set; }
        public string Notes { get; set; }
    }
}
