using Core.Persistence;

namespace Domain.Entities
{
    public class Department : Entity
    {
        public string DepartmentName { get; set; }
        public string DepartmentDescription { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}
