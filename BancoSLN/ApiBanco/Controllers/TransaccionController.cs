using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataApi.Fachada;
using DataApi.Dominio;
using System.Data;

namespace ApiBanco.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransaccionController : ControllerBase
    {
        private IDataApi dataApi;

        public TransaccionController()
        {
            dataApi = new DataApiIMP();
        }

        [HttpGet("/cuentas")]
        public IActionResult GetProductos()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dataApi.GetCuentas();
                return Ok(dt);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
        [HttpPost("/transaccion")]
        public IActionResult PostTransaccion(Transaccion transaccion)
        {
            try
            {
                if (transaccion == null)
                {
                    return BadRequest("Datos de Transaccion incorrectos!");
                }

                return Ok(dataApi.SaveTransaccion(transaccion));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
    }
}
