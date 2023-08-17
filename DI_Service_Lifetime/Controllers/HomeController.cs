using DI_Service_Lifetime.Models;
using DI_Service_Lifetime.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;

namespace DI_Service_Lifetime.Controllers
{
    public class HomeController : Controller
    {
        private readonly IScopedGuidService _scoped1;
        private readonly IScopedGuidService _scoped2;

        private readonly ISingletonGuidService _singleton1;
        private readonly ISingletonGuidService _singleton2;

        private readonly ITransientGuidService _transient1;
        private readonly ITransientGuidService _transient2;

        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IScopedGuidService scopeGuid1, IScopedGuidService scopeGuid2,
            ISingletonGuidService singletonGuid1, ISingletonGuidService singletonGuid2, 
            ITransientGuidService trasient1, ITransientGuidService trasient2)
        {
            _logger = logger;
            _scoped1 = scopeGuid1;
            _scoped2 = scopeGuid2;
            _singleton1 = singletonGuid1;
            _singleton2 = singletonGuid2;
            _transient1 = trasient1;
            _transient2 = trasient2;
        }

        public IActionResult Index()
        {
            StringBuilder message = new StringBuilder();
            message.Append($"Transient 1: {_transient1.GetGuid()}\n");
            message.Append($"Transient 2: {_transient1.GetGuid()}\n\n\n");
            message.Append($"scoped 1: {_scoped1.GetGuid()}\n");
            message.Append($"scoped 2: {_scoped2.GetGuid()}\n\n\n");
            message.Append($"singleton 1: {_singleton1.GetGuid()}\n");
            message.Append($"singleton 2: {_singleton2.GetGuid()}\n\n");

            return Ok(message.ToString());

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult  Error()

        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}