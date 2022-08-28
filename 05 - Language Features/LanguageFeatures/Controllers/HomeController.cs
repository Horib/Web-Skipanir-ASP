using Microsoft.AspNetCore.Mvc;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        //public ViewResult Index()
        //{
        //    //Product?[] products = Product.GetProducts();
        //    //return View(new string[] {
        //    //    $"Name: {products[0]?.Name}, Price: { products[0]?.Price }"
        //    //});

        //    //string[] names = new string[3];
        //    //names[0] = "Bob";
        //    //names[1] = "Joe";
        //    //names[2] = "Alice";
        //    //return View("Index", names);

        //    //return View("Index", new string[] { "Bob", "Joe", "Alice" });

        //    //Dictionary<string, Product> products = new Dictionary<string, Product> {
        //    //    { "Kayak", new Product { Name = "Kayak", Price = 275M } },
        //    //    { "Lifejacket", new Product { Name = "Lifejacket", Price = 48.95M } }
        //    //};
        //    //return View("Index", products.Keys);

        //    //Dictionary<string, Product> products = new Dictionary<string, Product> {
        //    //    ["Kayak"] = new Product { Name = "Kayak", Price = 275M },
        //    //    ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M }
        //    //};
        //    //return View("Index", products.Keys);


        //}

        //public async Task<ViewResult> Index()
        //{
        //    //long? length = await MyAsyncMethods.GetPageLength();
        //    //return View(new string[] { $"Length: {length}" });

        //    //List<string> output = new List<string>();
        //    //foreach (long? len in await MyAsyncMethods.GetPageLengths(output, "apress.com", "microsoft.com", "amazon.com"))
        //    //{
        //    //    output.Add($"Page length: { len}");
        //    //}
        //    //return View(output);

        //    List<string> output = new List<string>();
        //    await foreach (long? len in MyAsyncMethods.GetPageLengths(output, "apress.com", "microsoft.com", "amazon.com"))
        //    {
        //        output.Add($"Page length: {len}");
        //    }
        //    return View(output);

        //}

        public ViewResult Index()
        {
            var products = new[]
            {
                new { Name = "Kayak", Price = 275M },
                new { Name = "Lifejacket", Price = 48.95M },
                new { Name = "Soccer ball", Price = 19.50M },
                new { Name = "Corner flag", Price = 34.95M }
            };
            //return View(products.Select(p => $"Name: {p.Name}, Price: {p.Price}"));

            return View(products.Select(p => 
                $"{nameof(p.Name)}: {p.Name}, {nameof(p.Price)}: {p.Price}"));
        }
    }
}
