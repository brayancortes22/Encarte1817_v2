using System.Data;

namespace Entity.Model.Base
{
    public class RolFormPermission : BaseEntity
    {
        public int RolId { get; set; }
        public int FormId { get; set; }
        public int PermissionId { get; set; }

        public bool CanCreate { get; set; }
        public bool CanRead { get; set; }
        public bool CanUpdate { get; set; }
        public bool CanDelete { get; set; }

        public virtual Rol? Rol { get; set; }
        public virtual Permission? Permission { get; set; }



    }
}