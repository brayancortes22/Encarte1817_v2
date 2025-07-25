using Business.Interfaces;
using Entity.Dtos.ClientesDTO;
using Entity.Dtos.PedidosDTO;
using Entity.Model;
using Microsoft.AspNetCore.Components;
using Web.Controllers.Interface;

namespace Web.Controllers.Implements
{
    [Route("api/[controller]")]
    public class PedidosController : GenericController<PedidosDto, Pedidos>, IPedidosController
    {
        private readonly IPedidosBusiness _pedidosBusiness;

        public PedidosController(IPedidosBusiness pedidosBusiness, ILogger<PedidosController> logger)
            : base(pedidosBusiness, logger)
        {
            _pedidosBusiness = pedidosBusiness;
        }

        protected override int GetEntityId(PedidosDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
