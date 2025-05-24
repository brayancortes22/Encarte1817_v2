using System.ComponentModel.DataAnnotations;
using Entity.Dtos.Base;

namespace Entity.Dtos.PersonDTO
{
    /// <summary>
    /// DTO para mostrar información básica de una persona
    /// </summary>
    public class PersonDto : BaseDto
    {
        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(50, ErrorMessage = "El nombre no puede exceder 50 caracteres")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "El apellido es requerido")]
        [StringLength(50, ErrorMessage = "El apellido no puede exceder 50 caracteres")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El tipo de documento es requerido")]
        [StringLength(20, ErrorMessage = "El tipo de documento no puede exceder 20 caracteres")]
        public string DocumentType { get; set; }

        [Required(ErrorMessage = "El número de documento es requerido")]
        [StringLength(20, ErrorMessage = "El número de documento no puede exceder 20 caracteres")]
        public string DocumentNumber { get; set; }

        [StringLength(20, ErrorMessage = "El número de teléfono no puede exceder 20 caracteres")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "El ID del país es requerido")]
        public int CountryId { get; set; }

        [Required(ErrorMessage = "El ID del departamento es requerido")]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "El ID de la ciudad es requerido")]
        public int CityId { get; set; }

        [Required(ErrorMessage = "El ID del barrio es requerido")]
        public int NeighborhoodId { get; set; }
    }
}
