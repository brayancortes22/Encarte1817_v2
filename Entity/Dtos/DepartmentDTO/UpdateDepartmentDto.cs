using System.ComponentModel.DataAnnotations;
using Entity.Dtos.Base;

namespace Entity.Dtos.DepartmentDTO
{
    /// <summary>
    /// DTO para actualizar información de un departamento
    /// </summary>
    public class UpdateDepartmentDto : BaseDto
    {
        [StringLength(100, ErrorMessage = "El nombre no puede exceder 100 caracteres")]
        public string Name { get; set; }

        public int? CountryId { get; set; }
    }
}