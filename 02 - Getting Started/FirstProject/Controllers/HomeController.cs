using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers
{
    public class HomeController : Controller
    {
        //public ViewResult Index()
        //{
        //    return View("MyView");
        //}

        public ViewResult Index()
        {
        int hour = DateTime.Now.Hour;
        string viewModel = hour < 12 ? "Good morning" : "Good Afternoon";
            return View("MyView", viewModel);
        }
    }
}


