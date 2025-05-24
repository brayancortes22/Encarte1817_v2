using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.Base
{
    public class Person : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public string PhoneNumber { get; set; }

        // Foreign Keys
        public int CountryId { get; set; }
        public int DepartmentId { get; set; }
        public int CityId { get; set; }
        public int NeighborhoodId { get; set; }

        // Navigation properties
        public virtual Country? Country { get; set; }
        public virtual Department? Department { get; set; }
        public virtual City? City { get; set; }
        public virtual Neighborhood? Neighborhood { get; set; }

        // Related entities
        public virtual Client? Client { get; set; }
        public virtual Provider? Provider { get; set; }
        public virtual Employee? Employee { get; set; }
    }
}



