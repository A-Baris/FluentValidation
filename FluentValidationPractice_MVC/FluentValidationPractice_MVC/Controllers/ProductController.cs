using FluentValidation;
using FluentValidationPractice_MVC.Models;
using FluentValidationPractice_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationPractice_MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IValidator<ProductVM> _validator;

        public ProductController(IValidator<ProductVM> validator)
        {
            _validator = validator;
        }

        public IActionResult Create()
        {
            return View();
        }
        //Testing errorResult
        [HttpPost]
        public IActionResult Create(ProductVM productVM)
        {
            ModelState.Clear(); 
            var errorResult = _validator.Validate(productVM);
            if(errorResult.IsValid)
            {
                List<Product> productList = new List<Product>();
                Product product = new Product()
                {
                    Id = productVM.Id,
                    ProductName = productVM.ProductName,
                    Price = productVM.Price,
                    Description = productVM.Description,
                };
                productList.Add(product);
                return RedirectToAction("Index", "Home");

            }
            else
            {
               
                foreach (var error in errorResult.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
              
                return View(productVM);
            }
           
        }
    }
}
