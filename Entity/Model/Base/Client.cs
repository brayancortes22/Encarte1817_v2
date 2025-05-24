using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Enums;

namespace Entity.Model.Base
{
    public class Client : BaseEntity
    {
        public string ClientCode { get; set; }
        public string CompanyName { get; set; }
        public string TaxId { get; set; }
        public string BusinessType { get; set; }
        public string Website { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }


        // Dirección de envío - Solo lo que necesita desplegable
        public StreetType ShippingStreetType { get; set; }
        public string ShippingStreetNumber { get; set; }       // Usuario escribe: "100"
        public StreetLetter ShippingStreetLetter { get; set; } // Desplegable: A, B, C
        public string ShippingSecondaryNumber { get; set; }    // Usuario escribe: "5-32"
        public UnitType ShippingUnitType { get; set; }         // Desplegable: Apto, Casa, etc.
        public string ShippingUnitNumber { get; set; }         // Usuario escribe: "501"

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

        // Propiedades calculadas para mostrar la dirección completa

    }
}