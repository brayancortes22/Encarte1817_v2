using Entity.Dtos.Base;

namespace Entity.Dtos.PermissionDTO
{
    /// <summary>
    /// DTO para eliminación lógica de un permiso
    /// </summary>
    public class DeleteLogicalPermissionDto : BaseDto
    {
        public DeleteLogicalPermissionDto()
        {
            Status = false;
        }
    }
}