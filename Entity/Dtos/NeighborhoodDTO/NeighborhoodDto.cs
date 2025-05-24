using System.ComponentModel.DataAnnotations;
using Entity.Dtos.Base;

namespace Entity.Dtos.NeighborhoodDTO
{
    /// <summary>
    /// DTO para mostrar información básica de un barrio
    /// </summary>
    public class NeighborhoodDto : BaseDto
    {
        [Required(ErrorMessage = "El nombre del barrio es requerido")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder 100 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El ID de la ciudad es requerido")]
        public int CityId { get; set; }
    }
}