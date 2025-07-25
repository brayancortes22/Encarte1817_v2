using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Dtos.Base;

namespace Entity.Dtos.PizzasDTO
{
    public class PizzasDto : BaseDto
    {
        public string Nombre { get; set; } // Nombre de la pizza
        public string Descripcion { get; set; } // Descripción de la pizza
        public decimal Precio { get; set; } // Precio de la pizza

    }
}
