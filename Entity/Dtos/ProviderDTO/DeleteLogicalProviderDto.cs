using Entity.Dtos.Base;

namespace Entity.Dtos.ProviderDTO
{
    /// <summary>
    /// DTO para eliminación lógica de un proveedor
    /// </summary>
    public class DeleteLogicalProviderDto : BaseDto
    {
        public DeleteLogicalProviderDto()
        {
            Status = false;
        }
    }
}
