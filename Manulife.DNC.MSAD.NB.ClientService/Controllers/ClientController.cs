using Manulife.DNC.MSAD.Common;
using Manulife.DNC.MSAD.NB.ClientService.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Manulife.DNC.MSAD.NB.ClientService.Controllers
{
    [Produces("application/json")]
    [Route("api/Client")]
    public class ClientController : Controller
    {
        private readonly IClientService clientService;

        public ClientController(IClientService _clientService)
        {
            clientService = _clientService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var client = clientService.GetClientById(id);

            return Json(client);
        }
    }
}