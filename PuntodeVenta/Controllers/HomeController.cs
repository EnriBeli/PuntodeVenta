using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PuntodeVenta.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PuntodeVenta.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private user FldPassword;
        private object fldEmailAcount;
        HttpClient v_Client = new HttpClient();
        string url_api = "https://puntoventaarojo.azurewebsites.net/";
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public async Task<IActionResult> Index()
        {

            return View();
        }
        public async Task<IActionResult> Login(){

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(DTOUser user)
        {
            v_Client.BaseAddress = new Uri(url_api);
            var httpContent = new StringContent(JsonConvert.SerializeObject(user, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }), Encoding.UTF8, "application/json");

            var v_Response = v_Client.PostAsync("api/authenticateUser", httpContent).Result;
            var jsonResponse = await v_Response.Content.ReadAsStringAsync();
            DTOResponseLogin responseLogin= JsonConvert.DeserializeObject<DTOResponseLogin>(jsonResponse);

            return View("Bienvenido", responseLogin);
        }

        public async Task<IActionResult> Bienvenido()
        {

            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
