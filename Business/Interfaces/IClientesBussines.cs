using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Dtos;
using Entity.Dtos.ClientesDTO;
using Entity.Dtos.PizzasDTO;
using Entity.Model;

namespace Business.Interfaces
{
    public interface IClientesBusiness : IBaseBusiness<Clientes, ClientesDTO>
    {
    }
}
