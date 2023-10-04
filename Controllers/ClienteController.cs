using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Authorize]
    [Route("cliente")]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        [Route("listar")]
        public dynamic listarCliente()
        {
            List<Cliente> clientes = new List<Cliente>
            {
                new Cliente { Id = 1, correo = "rodolfo.0926@hotmail.com", edad = "24", nombre = "Rodolfo Navarro"}
            };

            return clientes;
        }
    }
}
