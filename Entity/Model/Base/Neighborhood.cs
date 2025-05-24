using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.Base
{
    public class Neighborhood : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int CityId { get; set; }

        // Navigation properties
        public virtual City? City { get; set; }
        public virtual ICollection<Person>? People { get; set; }
        public virtual ICollection<Client>? Clients { get; set; }
        public virtual ICollection<Provider>? Providers { get; set; }
        public virtual ICollection<Employee>? Employees { get; set; }
    }
}