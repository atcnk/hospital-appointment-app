using Core.Persistence;

namespace Domain.Entities
{
    public class Department : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}
