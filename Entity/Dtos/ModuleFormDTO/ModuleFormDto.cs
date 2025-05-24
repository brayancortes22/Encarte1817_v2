using System.ComponentModel.DataAnnotations;
using Entity.Dtos.Base;

namespace Entity.Dtos.ModuleFormDTO
{
    /// <summary>
    /// DTO para mostrar información básica de una relación módulo-formulario
    /// </summary>
    public class ModuleFormDto : BaseDto
    {
        [Required(ErrorMessage = "El ID del formulario es requerido")]
        public int FormId { get; set; }

        [Required(ErrorMessage = "El ID del módulo es requerido")]
        public int ModuleId { get; set; }

        // Propiedades de solo lectura para mostrar información relacionada
        public string FormName { get; set; }
        public string ModuleName { get; set; }
    }
}