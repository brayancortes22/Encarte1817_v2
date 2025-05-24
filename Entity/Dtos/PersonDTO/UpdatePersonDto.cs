using System.ComponentModel.DataAnnotations;
using Entity.Dtos.Base;

namespace Entity.Dtos.PersonDTO
{
    /// <summary>
    /// DTO para actualizar información de una persona
    /// </summary>
    public class UpdatePersonDto : BaseDto
    {
        [StringLength(50, ErrorMessage = "El nombre no puede exceder 50 caracteres")]
        public string FirstName { get; set; }

        [StringLength(50, ErrorMessage = "El apellido no puede exceder 50 caracteres")]
        public string LastName { get; set; }

        [StringLength(20, ErrorMessage = "El tipo de documento no puede exceder 20 caracteres")]
        public string DocumentType { get; set; }

        [StringLength(20, ErrorMessage = "El número de documento no puede exceder 20 caracteres")]
        public string DocumentNumber { get; set; }

        [StringLength(20, ErrorMessage = "El número de teléfono no puede exceder 20 caracteres")]
        public string PhoneNumber { get; set; }

        public int? CountryId { get; set; }
        public int? DepartmentId { get; set; }
        public int? CityId { get; set; }
        public int? NeighborhoodId { get; set; }
    }
}