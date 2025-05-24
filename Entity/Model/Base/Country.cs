using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.Base
{
    class Country : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public virtual ICollection<City>? Cities { get; set; } 
        public virtual ICollection<Person>? People { get; set; } 
    

    }
}
