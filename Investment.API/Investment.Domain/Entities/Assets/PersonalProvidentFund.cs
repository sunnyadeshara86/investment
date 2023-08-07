using Investment.Domain.Base;

namespace Investment.Domain.Entities.Assets
{
    public class PersonalProvidentFund : BaseEntity
    {
        public string CustomerId { get; set; }
        public string PPFNumber { get; set; }
        public int OrganizationId { get; set; }
        public int InvestorId { get; set; }
        public decimal InstallmentAmount { get; set; }
        public decimal RateOfInterest { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public decimal FundValue { get; set; }
        public DateOnly FundValueDate { get; set; }
        public string Notes { get; set; }
    }
}
