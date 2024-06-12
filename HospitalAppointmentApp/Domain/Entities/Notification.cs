using Core.Persistence;
using Domain.Enums;

namespace Domain.Entities
{
    public class Notification : Entity
    {    
        public NotificationType Type { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public DateTime SentAt { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
