using Data.Implements.BaseData;
using Data.Interfaces; // Añade esta línea
using Entity.Context;
using Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implements.PizzasData;

public class PizzasData : BaseModelData<Pizzas>, IPizzasData
{
    public PizzasData(ApplicationDbContext context) : base(context)
    {
    }
}
