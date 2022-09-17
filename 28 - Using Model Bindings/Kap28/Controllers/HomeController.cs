using Kap28.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Kap28.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index(Person person)
        ////public IActionResult Index([Bind("Name, Age")]Person person)
        //{
        //    ViewBag.MyMessage = $"Model Binding found this: Name={person.Name} and Age={person.Age} and Id={person.Id} and Administrator={person.Administrator}";

        //    return View();
        //}

        ////public IActionResult Array(string[] players)
        ////{
        ////    ViewBag.Players = players;
        ////    return View();
        ////}

        //public IActionResult Array(Family family)
        //{
        //    return View(family);
        //}

        //public IActionResult Index([FromQuery] int id)
        //{
        //    return Content($"Model Binder Found id={id}");
        //}        
        public IActionResult Index([FromHeader] string accept, [FromHeader(Name ="Accept-Language")] string lang)
        {
            return Content($"Model Binder Found accept={accept}, Accept-Language={lang}");
        }
    }
}