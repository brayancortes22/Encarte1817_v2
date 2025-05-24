using System.ComponentModel.DataAnnotations;
using Entity.Dtos.Base;

namespace Entity.Dtos.EmployeeDTO
{
    /// <summary>
    /// DTO para actualizar información de un empleado
    /// </summary>
    public class UpdateEmployeeDto : BaseDto
    {
        [StringLength(50, ErrorMessage = "El nombre no puede exceder 50 caracteres")]
        public string Name { get; set; }

        [StringLength(50, ErrorMessage = "El apellido no puede exceder 50 caracteres")]
        public string LastName { get; set; }

        [StringLength(20, ErrorMessage = "El código no puede exceder 20 caracteres")]
        public string EmployeeCode { get; set; }

        [StringLength(100, ErrorMessage = "El horario de trabajo no puede exceder 100 caracteres")]
        public string WorkSchedule { get; set; }

        public bool? IsActive { get; set; }

        public int? PersonId { get; set; }
        public int? CountryId { get; set; }
        public int? DepartmentId { get; set; }
        public int? CityId { get; set; }
        public int? NeighborhoodId { get; set; }
        public int? SupervisorId { get; set; }
    }
}