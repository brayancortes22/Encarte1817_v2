using System.ComponentModel.DataAnnotations;
using Entity.Dtos.Base;

namespace Entity.Dtos.CountryDTO
{
    /// <summary>
    /// DTO para actualizar información de un país
    /// </summary>
    public class UpdateCountryDto : BaseDto
    {
        [StringLength(100, ErrorMessage = "El nombre no puede exceder 100 caracteres")]
        public string Name { get; set; }

        [StringLength(5, ErrorMessage = "El código telefónico no puede exceder 5 caracteres")]
        public string PhoneCode { get; set; }
    }
}