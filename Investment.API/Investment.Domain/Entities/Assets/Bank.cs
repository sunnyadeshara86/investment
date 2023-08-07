using Investment.Domain.Base;
using Investment.Domain.Enums;

namespace Investment.Domain.Entities.Assets
{
    public class Bank : BaseEntity
    {
        public string AccountNumber { get; set; }
        public string CustomerId { get; set; }
        public int OrganizationId { get; set; }
        public AccountType AccountType { get; set; }
        public int OwnerId { get; set; }
        public decimal BalanceAmount { get; set; }
        public string Notes { get; set; }
    }
}
