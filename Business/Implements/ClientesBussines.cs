using AutoMapper;
using Business.Interfaces;
using Data.Interfaces;
using Entity.Dtos.ClientesDTO;
using Entity.Dtos.PizzasDTO;
using Entity.Model;
using Microsoft.Extensions.Logging;
using Utilities.Interfaces;

namespace Business.Implements
{
    /// <summary>
    
    /// </summary>
    public class ClientesBusiness : BaseBusiness<Clientes, ClientesDTO>, IClientesBusiness
    {
       
        private readonly IClientesData _clientesData;

        
        public ClientesBusiness(IClientesData clientesData, IMapper mapper, ILogger<ClientesBusiness> logger, IGenericIHelpers helpers)
      : base(clientesData, mapper, logger, helpers)
        {
            _clientesData = clientesData;
        }
    }
}
