using Entity.Dtos.ClientesDTO;
using Entity.Dtos.PedidosDTO;
using Entity.Model;

namespace Web.Controllers.Interface
{
    public interface IPedidosController : IGenericController<PedidosDto, Pedidos>
    {
    }
}
