using Entity.Dtos.Base;

namespace Entity.Dtos.ModuleDTO
{
    /// <summary>
    /// DTO para eliminación lógica de un módulo
    /// </summary>
    public class DeleteLogicalModuleDto : BaseDto
    {
        public DeleteLogicalModuleDto()
        {
            Status = false;


        }
    }
}