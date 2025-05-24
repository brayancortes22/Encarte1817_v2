using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.Base
{
    public class City : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string PostalCode { get; set; }
        public int DepartmentId { get; set; }

        // Navigation properties
        public virtual Department? Department { get; set; }
        public virtual ICollection<Neighborhood>? Neighborhoods { get; set; }
        public virtual ICollection<Person>? People { get; set; }
        public virtual ICollection<Client>? Clients { get; set; }
        public virtual ICollection<Provider>? Providers { get; set; }
        public virtual ICollection<Employee>? Employees { get; set; }
    }
}