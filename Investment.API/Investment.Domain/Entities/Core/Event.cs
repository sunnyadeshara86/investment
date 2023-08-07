using Investment.Domain.Base;

namespace Investment.Domain.Entities.Core
{
    public class Event : BaseEntity
    {
        public DateTime EventDateTime { get; set; }
        public string EntityType { get; set; }
        public string EventDetail { get; set; }

    }
}
