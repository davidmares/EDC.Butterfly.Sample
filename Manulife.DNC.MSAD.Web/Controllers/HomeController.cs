using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Manulife.DNC.MSAD.Web.Models;
using Microsoft.Extensions.Configuration;
using System.Net.Http;

namespace Manulife.DNC.MSAD.Web.Controllers
{
    public class HomeController : Controller
    {
        private string gatewayUri;

        public HomeController(IConfiguration configuration)
        {
            gatewayUri = $"http://{configuration["Gateway:IP"]}:{configuration["Gateway:Port"]}";
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About([FromServices]HttpClient httpClient)
        {
            var result = httpClient.GetStreamAsync($"{gatewayUri}/api/clientservice/trace").GetAwaiter().GetResult();

            ViewData["Message"] = $"Your request data result : {result}";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
