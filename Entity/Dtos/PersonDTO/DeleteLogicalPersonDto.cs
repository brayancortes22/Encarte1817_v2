using Entity.Dtos.Base;

namespace Entity.Dtos.PersonDTO
{
    /// <summary>
    /// DTO para eliminación lógica de una persona
    /// </summary>
    public class DeleteLogicalPersonDto : BaseDto
    {
        public DeleteLogicalPersonDto()
        {
            Status = false;
        }
    }
}