using Microsoft.AspNetCore.Mvc;
using Entity.Dtos.ClientesDTO;
using Entity.Model;
using Web.Controllers.Interface;
using Business.Interfaces;

namespace Web.Controllers.Implements
{
    [Route("api/[controller]")]
    public class RoleController : GenericController<RolDto, Rol>, IRoleController
    {
        private readonly IRolBusiness _rolBusiness;

        public RoleController(IRolBusiness rolBusiness, ILogger<RoleController> logger)
            : base(rolBusiness, logger)
        {
            _rolBusiness = rolBusiness;
        }

        protected override int GetEntityId(RolDto dto)
        {
            return dto.Id;
        }

        [HttpPatch]
        public async Task<IActionResult> UpdatePartialRole(int id , int roleId,[FromBody]  UpdateRolDto dto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var result = await _rolBusiness.UpdatePartialRolAsync(dto);
                return Ok(new { Success = result });
            }
            catch (ArgumentException ex)
            {
                _logger.LogError($"Error de validación al actualizar parcialmente rol: {ex.Message}");
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al actualizar parcialmente rol: {ex.Message}");
                return StatusCode(500, "Error interno del servidor");
            }
        }

        [HttpDelete("logic/{id}")]
        public async Task<IActionResult> DeleteLogicRole(int id)
        {
            try
            {
                var dto = new DeleteLogiRolDto { Id = id, Status = false }; // Se inicializa la propiedad requerida 'Status'
                var result = await _rolBusiness.DeleteLogicRolAsync(dto);
                if (!result)
                    return NotFound($"Rol con ID {id} no encontrado");

                return Ok(new { Success = true });
            }
            catch (ArgumentException ex)
            {
                _logger.LogError($"Error de validación al eliminar lógicamente rol: {ex.Message}");
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al eliminar lógicamente rol con ID {id}: {ex.Message}");
                return StatusCode(500, "Error interno del servidor");
            }
        }

    }
}