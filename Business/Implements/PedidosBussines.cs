using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Business.Interfaces;
using Data.Interfaces;
using Entity.Dtos.PedidosDTO;
using Entity.Model;
using Microsoft.Extensions.Logging;
using Utilities.Interfaces;

namespace Business.Implements
{
    public class PedidosBusiness : BaseBusiness<Pedidos, PedidosDto>, IPedidosBusiness
    {

        private readonly IPedidosData _pedidosData;


        public PedidosBusiness(IPedidosData pedidosData, IMapper mapper, ILogger<PedidosBusiness> logger, IGenericIHelpers helpers)
      : base(pedidosData, mapper, logger, helpers)
        {
            _pedidosData = pedidosData;
        }
    }
}

