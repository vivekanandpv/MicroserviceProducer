using Microsoft.AspNetCore.Mvc;

namespace MicroserviceProducer.Controllers
{
    public class CustomersController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}