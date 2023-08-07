using Investment.Domain.Base;

namespace Investment.Domain.Entities.Assets
{
    public class Cash : BaseEntity
    {
        public int OwnerId { get; set; }
        public string Location { get; set; }
        public decimal Amount { get; set; }
        public string Notes { get; set; }
    }
}
