using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Dtos.PedidosDTO;
using Entity.Model;

namespace Business.Interfaces
{
    public interface IPedidosBusiness : IBaseBusiness<Pedidos, PedidosDto>
    {
    }
}
