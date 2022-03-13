using Microsoft.AspNetCore.Mvc;

namespace bKashASPCore.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            bKashCore.bKashApi.callBack = paymentDone;
        }
        public IActionResult Index()
        {
            return View();
        }
        public void paymentDone(object data)
        {

        }
    }
}
