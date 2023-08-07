using Investment.Domain.Base;

namespace Investment.Domain.Entities.Assets
{
    public class MutualFund : BaseEntity
    {
        public string FundName { get; set; }
        public int InvestorId { get; set; }
        public decimal NumberOfUnits { get; set; }
        public decimal NetAssetValue { get; set; }
        public string Notes { get; set; }
    }
}
