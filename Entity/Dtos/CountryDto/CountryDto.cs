using Entity.Dtos.Base;
using System.ComponentModel.DataAnnotations;

namespace Entity.Dtos.CountryDTO
{
    public class CountryDto : BaseDto
    {
        [Required(ErrorMessage = "El nombre del país es requerido")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder 100 caracteres")]
        public string Name { get; set; }


        [StringLength(5, ErrorMessage = "El código telefónico no puede exceder 5 caracteres")]
        public string PhoneCode { get; set; }
    }
}