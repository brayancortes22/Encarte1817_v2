using System.ComponentModel.DataAnnotations;
using Entity.Dtos.Base;

namespace Entity.Dtos.ModuleFormDTO
{
    /// <summary>
    /// DTO para actualizar información de una relación módulo-formulario
    /// </summary>
    public class UpdateModuleFormDto : BaseDto
    {
        public int? FormId { get; set; }
        public int? ModuleId { get; set; }
    }
}