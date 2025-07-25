using Entity.Dtos.ClientesDTO;
using Entity.Model;

namespace Web.Controllers.Interface
{
    public interface IClientesController : IGenericController<ClientesDTO, Clientes>
    {
    }
}
