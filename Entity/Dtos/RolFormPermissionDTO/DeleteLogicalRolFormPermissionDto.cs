using Entity.Dtos.Base;

namespace Entity.Dtos.RolFormPermissionDTO
{
    /// <summary>
    /// DTO para eliminación lógica de permisos de rol en formularios
    /// </summary>
    public class DeleteLogicalRolFormPermissionDto : BaseDto
    {
        public DeleteLogicalRolFormPermissionDto()
        {
            Status = false;
        }

    }
}