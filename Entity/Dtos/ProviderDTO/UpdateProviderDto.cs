using System.ComponentModel.DataAnnotations;
using Entity.Dtos.Base;

namespace Entity.Dtos.ProviderDTO
{
    /// <summary>
    /// DTO para actualizar información de un proveedor
    /// </summary>
    public class UpdateProviderDto : BaseDto
    {
        [StringLength(20, ErrorMessage = "El código no puede exceder 20 caracteres")]
        public string ProviderCode { get; set; }

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

        [StringLength(500, ErrorMessage = "Los productos/servicios no pueden exceder 500 caracteres")]
        public string ProductsServices { get; set; }

        [StringLength(100, ErrorMessage = "Los términos de pago no pueden exceder 100 caracteres")]
        public string PaymentTerms { get; set; }

        public int? PersonId { get; set; }
        public int? CountryId { get; set; }
        public int? DepartmentId { get; set; }
        public int? CityId { get; set; }
        public int? NeighborhoodId { get; set; }
    }
}