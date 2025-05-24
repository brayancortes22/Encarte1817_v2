using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.Base
{
    public class Client : BaseEntity
    {
        public string ClientCode { get; set; }
        public string CompanyName { get; set; }
        public string TaxId { get; set; }
        public string Website { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public string ShippingAddress { get; set; }
        public decimal CreditLimit { get; set; }
        public string PaymentTerms { get; set; }
        public DateTime RegistrationDate { get; set; }

        // Foreign Keys
        public int PersonId { get; set; }
        public int CountryId { get; set; }
        public int DepartmentId { get; set; }
        public int CityId { get; set; }
        public int NeighborhoodId { get; set; }

        // Navigation properties
        public virtual Person? Person { get; set; }
        public virtual Country? Country { get; set; }
        public virtual Department? Department { get; set; }
        public virtual City? City { get; set; }
        public virtual Neighborhood? Neighborhood { get; set; }
    }
}