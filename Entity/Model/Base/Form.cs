using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.Base
{
   public class Form:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<ModuleForm> ModuleForm { get; set; }
        
    }
}
