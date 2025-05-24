using Entity.Dtos.Base;

namespace Entity.Dtos.EmployeeDTO
{
    /// <summary>
    /// DTO para eliminación lógica de un empleado
    /// </summary>
    public class DeleteLogicalEmployeeDto : BaseDto
    {
        public DeleteLogicalEmployeeDto()
        {
            Status = false;
        }
    }
}