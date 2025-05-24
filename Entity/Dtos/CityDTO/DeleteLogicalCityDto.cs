using Entity.Dtos.Base;

namespace Entity.Dtos.CityDTO
{
    /// <summary>
    /// DTO para eliminación lógica de una ciudad
    /// </summary>
    public class DeleteLogicalCityDto : BaseDto
    {
        public DeleteLogicalCityDto()
        {
            Status = false;
        }
    }
}