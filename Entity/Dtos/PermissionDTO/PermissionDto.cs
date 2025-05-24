using System.ComponentModel.DataAnnotations;
using Entity.Dtos.Base;

namespace Entity.Dtos.PermissionDTO
{
    /// <summary>
    /// DTO para mostrar información básica de un permiso
    /// </summary>
    public class PermissionDto : BaseDto
    {
        [Required(ErrorMessage = "El nombre del permiso es requerido")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder 100 caracteres")]
        public string Name { get; set; }

        [StringLength(500, ErrorMessage = "La descripción no puede exceder 500 caracteres")]
        public string Description { get; set; }
    }
}