using Entity.Dtos.Base;

namespace Entity.Dtos.DepartmentDTO
{
    /// <summary>
    /// DTO para eliminación lógica de un departamento
    /// </summary>
    public class DeleteLogicalDepartmentDto : BaseDto
    {
        public DeleteLogicalDepartmentDto()
        {
            Status = false;
        }
    }
}