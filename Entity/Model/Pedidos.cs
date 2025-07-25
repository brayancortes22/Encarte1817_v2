using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Model.Base;

namespace Entity.Model
{
    public class Pedidos : BaseDTO
    {
        public int ClienteId { get; set; }
        public Clientes Cliente { get; set; } // Relación con Cliente
        public int pizzasId { get; set; }
        public Pizzas Pizzas { get; set; } // Relación con Pizza
        public DateTime FechaPedido { get; set; }
        public string Estado { get; set; } // Ejemplo: "Pendiente", "En preparación", "Entregado"
        public int Cantidad { get; set; } // Cantidad de pizzas pedidas

    }
}
