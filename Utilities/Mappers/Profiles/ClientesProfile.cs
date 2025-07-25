using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Entity.Dtos.PizzasDTO;
using Entity.Model;

namespace Utilities.Mappers.Profiles
{
    public class ClientesProfile : Profile
    {
        public ClientesProfile()
        {
          
            CreateMap<Clientes, PizzasDTO>().ReverseMap();
        }
    }
}