using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Entity.Dtos.PedidosDTO;
using Entity.Model;

namespace Utilities.Mappers.Profiles
{
    public class PedidosProfile : Profile
    {
        public PedidosProfile()
        {

            CreateMap<Pedidos, PedidosDto>().ReverseMap();
        }
    }
}

