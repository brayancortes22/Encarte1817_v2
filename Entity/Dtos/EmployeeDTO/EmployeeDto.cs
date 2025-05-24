using System.ComponentModel.DataAnnotations;
using Entity.Dtos.Base;

namespace Entity.Dtos.EmployeeDTO
{
    /// <summary>
    /// DTO para mostrar información básica de un empleado
    /// Incluye información de la persona asociada
    /// </summary>
    public class EmployeeDto : BaseDto
    {
        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(50, ErrorMessage = "El nombre no puede exceder 50 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El apellido es requerido")]
        [StringLength(50, ErrorMessage = "El apellido no puede exceder 50 caracteres")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El código del empleado es requerido")]
        [StringLength(20, ErrorMessage = "El código no puede exceder 20 caracteres")]
        public string EmployeeCode { get; set; }

        [StringLength(100, ErrorMessage = "El horario de trabajo no puede exceder 100 caracteres")]
        public string WorkSchedule { get; set; }

        public bool IsActive { get; set; }

        // Datos de la persona asociada
        [Required(ErrorMessage = "El ID de la persona es requerido")]
        public int PersonId { get; set; }

        // Datos de ubicación (heredados de Person)
        [Required(ErrorMessage = "El ID del país es requerido")]
        public int CountryId { get; set; }

        [Required(ErrorMessage = "El ID del departamento es requerido")]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "El ID de la ciudad es requerido")]
        public int CityId { get; set; }

        [Required(ErrorMessage = "El ID del barrio es requerido")]
        public int NeighborhoodId { get; set; }

        public int? SupervisorId { get; set; }

        // Propiedades de solo lectura para mostrar datos de la persona
        public string PersonFirstName { get; set; }
        public string PersonLastName { get; set; }
        public string PersonDocumentType { get; set; }
        public string PersonDocumentNumber { get; set; }
        public string PersonPhoneNumber { get; set; }

        // Información del supervisor
        public string SupervisorName { get; set; }
    }
}