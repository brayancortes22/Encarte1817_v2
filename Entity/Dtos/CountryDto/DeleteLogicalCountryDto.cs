using Entity.Dtos.Base;

namespace Entity.Dtos.CountryDTO
{
    /// <summary>
    /// DTO para eliminación lógica de un país
    /// </summary>
    public class DeleteLogicalCountryDto : BaseDto
    {
        public DeleteLogicalCountryDto()
        {
            Status = false;
        }
    }
}