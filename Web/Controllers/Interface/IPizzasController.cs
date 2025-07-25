
using Entity.Dtos.PizzasDTO;
using Entity.Model;

namespace Web.Controllers.Interface
{
    public interface IPizzasController : IGenericController<PizzasDto, Pizzas>
    {
    }
}
