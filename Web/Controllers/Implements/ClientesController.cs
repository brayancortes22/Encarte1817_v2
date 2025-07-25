using Business.Interfaces;
using Entity.Dtos.ClientesDTO;
using Entity.Model;
using Microsoft.AspNetCore.Components;
using Web.Controllers.Interface;

namespace Web.Controllers.Implements
{
    [Route("api/[controller]")]
    public class ClientesController : GenericController<ClientesDTO, Clientes>, IClientesController
    {
        private readonly IClientesBusiness _clientesBusiness;

        public ClientesController(IClientesBusiness ClientesBusiness, ILogger<ClientesController> logger)
            : base(ClientesBusiness, logger)
        {
            _clientesBusiness = ClientesBusiness;
        }

        protected override int GetEntityId(ClientesDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
