using System.ComponentModel.DataAnnotations;
using Entity.Dtos.Base;

namespace Entity.Dtos.RolFormPermissionDTO
{
    /// <summary>
    /// DTO para actualizar permisos de rol en formularios
    /// </summary>
    public class UpdateRolFormPermissionDto : BaseDto
    {
        public int? RolId { get; set; }
        public int? FormId { get; set; }
        public int? PermissionId { get; set; }

        public bool? CanCreate { get; set; }
        public bool? CanRead { get; set; }
        public bool? CanUpdate { get; set; }
        public bool? CanDelete { get; set; }
    }
}