using System.ComponentModel.DataAnnotations;
using Entity.Dtos.Base;

namespace Entity.Dtos.RolFormPermissionDTO
{
    /// <summary>
    /// DTO para mostrar información básica de permisos de rol en formularios
    /// </summary>
    public class RolFormPermissionDto : BaseDto
    {
        [Required(ErrorMessage = "El ID del rol es requerido")]
        public int RolId { get; set; }

        [Required(ErrorMessage = "El ID del formulario es requerido")]
        public int FormId { get; set; }

        [Required(ErrorMessage = "El ID del permiso es requerido")]
        public int PermissionId { get; set; }

        public bool CanCreate { get; set; }
        public bool CanRead { get; set; }
        public bool CanUpdate { get; set; }
        public bool CanDelete { get; set; }

        // Propiedades de solo lectura para mostrar información relacionada
        public string RolName { get; set; }
        public string FormName { get; set; }
        public string PermissionName { get; set; }
    }
}

