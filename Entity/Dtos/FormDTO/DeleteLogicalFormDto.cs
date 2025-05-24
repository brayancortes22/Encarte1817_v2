using Entity.Dtos.Base;


namespace Entity.Dtos.FormDTO
{
    /// <summary>
    /// DTO para eliminación lógica de un formulario
    /// </summary>
    public class DeleteLogicalFormDto : BaseDto
    {
        public DeleteLogicalFormDto()
        {
            Status = false;
        }
    }
}