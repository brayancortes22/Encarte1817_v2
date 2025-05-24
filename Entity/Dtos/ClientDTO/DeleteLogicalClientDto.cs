using Entity.Dtos.Base;

namespace Entity.Dtos.ClientDTO
{
    /// <summary>
    /// DTO para eliminación lógica de un cliente
    /// </summary>
    public class DeleteLogicalClientDto : BaseDto
    {
        public DeleteLogicalClientDto()
        {
            Status = false;
        }
    }
}