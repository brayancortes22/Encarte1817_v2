using Entity.Dtos.Base;

namespace Entity.Dtos.NeighborhoodDTO
{
    /// <summary>
    /// DTO para eliminación lógica de un barrio
    /// </summary>
    public class DeleteLogicalNeighborhoodDto : BaseDto
    {
        public DeleteLogicalNeighborhoodDto()
        {
            Status = false;
        }
    }
}