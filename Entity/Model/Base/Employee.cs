using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.Base
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string EmployeeCode { get; set; }
        public string WorkSchedule { get; set; }
        public bool IsActive { get; set; }

        // Foreign Keys
        public int PersonId { get; set; }
        public int CountryId { get; set; }
        public int DepartmentId { get; set; }
        public int CityId { get; set; }
        public int NeighborhoodId { get; set; }
        public int? SupervisorId { get; set; }

        // Navigation properties
        public virtual Person? Person { get; set; }
        public virtual Country? Country { get; set; }
        public virtual Department? Department { get; set; }
        public virtual City? City { get; set; }
        public virtual Neighborhood? Neighborhood { get; set; }
        public virtual Employee? Supervisor { get; set; }
        public virtual ICollection<Employee>? Subordinates { get; set; }
    }
}