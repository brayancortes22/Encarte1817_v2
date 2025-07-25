using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Dtos.Base;

namespace Entity.Dtos.ClientesDTO
{
    /// <summary>
    /// DTO para la creación de un nuevo rol (operación Delete Logico)
    /// </summary>
    public class DeleteLogiRolDto : BaseDto
    {
        public DeleteLogiRolDto()
        {
            Status = false;
        }
    }
}
