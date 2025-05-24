using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.Base
{
    public class Provider : BaseEntity
    {
        public string ProviderCode { get; set; }
        public string CompanyName { get; set; }
        public string TaxId { get; set; }
        public string BusinessType { get; set; }
        public string Website { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public string Address { get; set; }
        public string ProductsServices { get; set; }
        public string PaymentTerms { get; set; }
        public decimal Rating { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool IsActive { get; set; }
        
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