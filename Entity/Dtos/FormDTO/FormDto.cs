using System.ComponentModel.DataAnnotations;
using Entity.Dtos.Base;

namespace Entity.Dtos.FormDTO
{
    /// <summary>
    /// DTO para mostrar información básica de un formulario
    /// </summary>
    public class FormDto : BaseDto
    {
        [Required(ErrorMessage = "El nombre del formulario es requerido")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder 100 caracteres")]
        public string Name { get; set; }

        [StringLength(500, ErrorMessage = "La descripción no puede exceder 500 caracteres")]
        public string Description { get; set; }
    }
}