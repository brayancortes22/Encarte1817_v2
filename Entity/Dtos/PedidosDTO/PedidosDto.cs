using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Dtos.Base;

namespace Entity.Dtos.PedidosDTO
{
    public class PedidosDto: BaseDto
    {
        public int ClienteId { get; set; }
        public int PizzasId { get; set; }
        public DateTime FechaPedido { get; set; }
        public string Estado { get; set; } // Ejemplo: "Pendiente", "En preparación", "Entregado"
        public int Cantidad { get; set; } // Cantidad de pizzas pedidas
    }
}
