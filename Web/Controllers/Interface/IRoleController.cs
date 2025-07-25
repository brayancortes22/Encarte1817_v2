using Microsoft.AspNetCore.Mvc;
using Entity.Dtos.ClientesDTO;
using Entity.Model;

namespace Web.Controllers.Interface
{
    public interface IRoleController : IGenericController<RolDto, Rol>
    {
        Task<IActionResult> UpdatePartialRole( int id, int roleId, UpdateRolDto dto);
        Task<IActionResult> DeleteLogicRole(int id);
    }
}