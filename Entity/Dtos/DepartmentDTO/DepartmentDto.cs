using System.ComponentModel.DataAnnotations;
using Entity.Dtos.Base;

namespace Entity.Dtos.DepartmentDTO
{
    /// <summary>
    /// DTO para mostrar información básica de un departamento
    /// </summary>
    public class DepartmentDto : BaseDto
    {
        [Required(ErrorMessage = "El nombre del departamento es requerido")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder 100 caracteres")]
        public string Name { get; set; }

      

        [Required(ErrorMessage = "El ID del país es requerido")]
        public int CountryId { get; set; }
    }
}