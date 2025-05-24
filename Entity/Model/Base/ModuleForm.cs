namespace Entity.Model.Base
{
    public class ModuleForm : BaseEntity
    {

        public int FormId { get; set; }
        public int ModuleId { get; set; }
        public virtual Form? Form { get; set; }
        public virtual Module? Module { get; set; }
    }
}