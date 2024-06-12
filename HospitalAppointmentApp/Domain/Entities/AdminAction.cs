using Core.Persistence;
using Domain.Enums;

namespace Domain.Entities
{
    public class AdminAction : Entity
    {
        public ActionType Type { get; set; }
        public string ActionDetails { get; set; }
        public int AdminId { get; set; }
        public virtual Admin Admin { get; set; }
    }
}
