using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Model;
using Entity.Dtos.PizzasDTO;

namespace Business.Interfaces
{
    public interface IPizzasBusiness : IBaseBusiness<Pizzas,PizzasDto>
    {
    }
}
