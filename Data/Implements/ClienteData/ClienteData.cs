using Data.Implements.BaseData;
using Data.Interfaces;
using Entity.Context;
using Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implements.RolData
{
    public class ClienteData : BaseModelData<Clientes>, IClientesData
    {
        public ClienteData(ApplicationDbContext context) : base(context)
        {
        }

      

    }
}
