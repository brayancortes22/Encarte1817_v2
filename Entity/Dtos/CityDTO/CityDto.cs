using System.ComponentModel.DataAnnotations;
using Entity.Dtos.Base;

namespace Entity.Dtos.CityDTO
{
    /// <summary>
    /// DTO para mostrar información básica de una ciudad
    /// </summary>
    public class CityDto : BaseDto
    {
        [Required(ErrorMessage = "El nombre de la ciudad es requerido")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder 100 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El código de la ciudad es requerido")]
        [StringLength(10, ErrorMessage = "El código no puede exceder 10 caracteres")]
        public string Code { get; set; }

        [StringLength(20, ErrorMessage = "El código postal no puede exceder 20 caracteres")]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "El ID del departamento es requerido")]
        public int DepartmentId { get; set; }
    }
}