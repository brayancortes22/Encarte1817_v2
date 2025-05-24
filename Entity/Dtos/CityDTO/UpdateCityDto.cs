using System.ComponentModel.DataAnnotations;
using Entity.Dtos.Base;

namespace Entity.Dtos.CityDTO
{
    /// <summary>
    /// DTO para actualizar información de una ciudad
    /// </summary>
    public class UpdateCityDto : BaseDto
    {
        [StringLength(100, ErrorMessage = "El nombre no puede exceder 100 caracteres")]
        public string Name { get; set; }

        [StringLength(10, ErrorMessage = "El código no puede exceder 10 caracteres")]
        public string Code { get; set; }

        [StringLength(20, ErrorMessage = "El código postal no puede exceder 20 caracteres")]
        public string PostalCode { get; set; }

        public int? DepartmentId { get; set; }
    }
}
