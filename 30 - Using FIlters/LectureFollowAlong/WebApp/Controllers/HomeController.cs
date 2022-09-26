using Microsoft.AspNetCore.Mvc;
using WebApp.Filters;

namespace WebApp.Controllers {

    //[SimpleCache]
    [ResultDiagnostics]
    public class HomeController : Controller {

        public IActionResult Index() {
            return View("Message",
                $"{DateTime.Now.ToLongTimeString()}: This is the Message from Controller Action");
        }

        [ChangeArg]
        public IActionResult Message(string message1, string message2 = "None")
        {
            return View("Message", $"{message1}{message2}");
        }
    }
}
