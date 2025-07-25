using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Entity.Dtos.Base;

namespace Entity.Dtos.ClientesDTO
{
    /// <summary>
    /// DTO para mostrar información básica de un rol (operación GET ALL,CREATE,UPDATE(PATCH-PUT))
    /// </summary>
    public class RolDto : BaseDto
    {
        public  string Name { get; set; }
        public  string Description { get; set; }
    }
}
