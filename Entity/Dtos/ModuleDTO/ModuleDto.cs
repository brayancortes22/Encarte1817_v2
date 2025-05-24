using System.ComponentModel.DataAnnotations;
using Entity.Dtos.Base;

namespace Entity.Dtos.ModuleDTO
{
    /// <summary>
    /// DTO para mostrar información básica de un módulo
    /// </summary>
    public class ModuleDto : BaseDto
    {
        [Required(ErrorMessage = "El nombre del módulo es requerido")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder 100 caracteres")]
        public string Name { get; set; }

        [StringLength(500, ErrorMessage = "La descripción no puede exceder 500 caracteres")]
        public string Description { get; set; }
    }
}