using Microsoft.AspNetCore.Mvc;

namespace ThaysPController.Controllers
{
    public class ThaysPController : Controller
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}