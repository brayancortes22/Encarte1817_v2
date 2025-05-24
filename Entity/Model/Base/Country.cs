using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.Base
{
    public class Country : BaseEntity
    {
        public string Name { get; set; }
        public string PhoneCode { get; set; }

        // Navigation properties
        public virtual ICollection<Department>? Departments { get; set; }
        public virtual ICollection<Person>? People { get; set; }
        public virtual ICollection<Client>? Clients { get; set; }
        public virtual ICollection<Provider>? Providers { get; set; }
        public virtual ICollection<Employee>? Employees { get; set; }
    }
}