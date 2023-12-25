using Microsoft.AspNetCore.Mvc;

namespace ChatSignalR.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
