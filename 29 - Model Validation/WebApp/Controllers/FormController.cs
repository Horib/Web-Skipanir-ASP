using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace WebApp.Controllers {

    [AutoValidateAntiforgeryToken]
    public class FormController : Controller {
        private DataContext context;

        public FormController(DataContext dbContext) {
            context = dbContext;
        }

        public async Task<IActionResult> Index(long? id) {
            return View("Form", await context.Products
                .FirstOrDefaultAsync(p => id == null || p.ProductId == id));
        }

        [HttpPost]
        public IActionResult SubmitForm(Product product) {

            //if(ModelState.GetValidationState(nameof(Product.Price))
            //    == ModelValidationState.Valid && product.Price <= 0)
            //{
            //    ModelState.AddModelError(nameof(Product.Price),
            //        "Enter a positive price");
            //}

            //if(ModelState.GetValidationState(nameof(Product.Name))
            //    == ModelValidationState.Valid
            //    && ModelState.GetValidationState(nameof(Product.Price))
            //    == ModelValidationState.Valid
            //    && product.Name.ToLower().StartsWith("small") && product.Price > 100)
            //{
            //    ModelState.AddModelError("", "Small products cannot cost more than $100");
            //}

            //if(ModelState.GetValidationState(nameof(Product.CategoryId))
            //    == ModelValidationState.Valid && !context.Categories.Any(c => 
            //        c.CategoryId == product.CategoryId))
            //{
            //    ModelState.AddModelError(nameof(Product.CategoryId),
            //        "Enter an existing category ID");
            //}

            //if (ModelState.GetValidationState(nameof(Product.SupplierId))
            //     == ModelValidationState.Valid && !context.Suppliers.Any(s =>
            //         s.SupplierId == product.SupplierId))
            //{
            //    ModelState.AddModelError(nameof(Product.SupplierId),
            //        "Enter an existing supplier ID");
            //}

            // ----------------------

            if (ModelState.IsValid)
            {
                TempData["name"] = product.Name;
                TempData["price"] = product.Price.ToString();
                TempData["categoryId"] = product.CategoryId.ToString();
                TempData["supplierId"] = product.SupplierId.ToString();
                return RedirectToAction(nameof(Results));
            }
            else
            {
                return View("Form");
            }
        }

        public IActionResult Results() {
            return View(TempData);
        }
    }
}
