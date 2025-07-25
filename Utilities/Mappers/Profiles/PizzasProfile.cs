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
    public class PizzasProfile : Profile
    {
        public PizzasProfile()
        {

            CreateMap<Pizzas, PizzasDto>().ReverseMap();
        }
    }
}