using Entity.Dtos.Base;

namespace Entity.Dtos.ModuleFormDTO
{
    /// <summary>
    /// DTO para eliminación lógica de una relación módulo-formulario
    /// </summary>
    public class DeleteLogicalModuleFormDto : BaseDto
    {
        public DeleteLogicalModuleFormDto()
        {
            Status = false;
        }
    }
}