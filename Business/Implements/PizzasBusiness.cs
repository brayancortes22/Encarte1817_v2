using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Business.Interfaces;
using Data.Interfaces;
using Entity.Dtos.PizzasDTO;
using Entity.Model;
using Microsoft.Extensions.Logging;
using Utilities.Interfaces;

namespace Business.Implements
{
    public class PizzasBusiness : BaseBusiness<Pizzas, PizzasDto>, IPizzasBusiness
    {

        private readonly IPizzasData _pizzasData;

        /// <summary>

        /// </summary>
        public PizzasBusiness(IPizzasData pizzasData, IMapper mapper, ILogger<PizzasBusiness> logger, IGenericIHelpers helpers)
      : base(pizzasData, mapper, logger, helpers)
        {
            _pizzasData = pizzasData;
        }
    }
}
