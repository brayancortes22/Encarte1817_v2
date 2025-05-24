using System.ComponentModel.DataAnnotations;
using Entity.Dtos.Base;
using Entity.Enums;

namespace Entity.Dtos.ClientDTO
{
    /// <summary>
    /// DTO para actualizar información de un cliente
    /// </summary>
    public class UpdateClientDto : BaseDto
    {
        [StringLength(20, ErrorMessage = "El código no puede exceder 20 caracteres")]
        public string ClientCode { get; set; }

        [StringLength(200, ErrorMessage = "El nombre de la empresa no puede exceder 200 caracteres")]
        public string CompanyName { get; set; }

        [StringLength(20, ErrorMessage = "El NIT no puede exceder 20 caracteres")]
        public string TaxId { get; set; }

        [StringLength(100, ErrorMessage = "El tipo de negocio no puede exceder 100 caracteres")]
        public string BusinessType { get; set; }

        [StringLength(200, ErrorMessage = "El sitio web no puede exceder 200 caracteres")]
        public string Website { get; set; }

        [EmailAddress(ErrorMessage = "El formato del email no es válido")]
        [StringLength(100, ErrorMessage = "El email no puede exceder 100 caracteres")]
        public string ContactEmail { get; set; }

        [StringLength(20, ErrorMessage = "El teléfono de contacto no puede exceder 20 caracteres")]
        public string ContactPhone { get; set; }

        public StreetType? ShippingStreetType { get; set; }
        public string ShippingStreetNumber { get; set; }
        public StreetLetter? ShippingStreetLetter { get; set; }
        public string ShippingSecondaryNumber { get; set; }
        public UnitType? ShippingUnitType { get; set; }
        public string ShippingUnitNumber { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "El límite de crédito debe ser mayor o igual a 0")]
        public decimal? CreditLimit { get; set; }

        public string PaymentTerms { get; set; }
        public DateTime? RegistrationDate { get; set; }

        public int? PersonId { get; set; }
        public int? CountryId { get; set; }
        public int? DepartmentId { get; set; }
        public int? CityId { get; set; }
        public int? NeighborhoodId { get; set; }
    }
}