using System.ComponentModel.DataAnnotations;
using Entity.Dtos.Base;

namespace Entity.Dtos.NeighborhoodDTO
{
    /// <summary>
    /// DTO para actualizar información de un barrio
    /// </summary>
    public class UpdateNeighborhoodDto : BaseDto
    {
        [StringLength(100, ErrorMessage = "El nombre no puede exceder 100 caracteres")]
        public string Name { get; set; }

        public int? CityId { get; set; }
    }
}