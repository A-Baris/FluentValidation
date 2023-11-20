using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace FluentValidationPractice_MVC.ViewModels
{
    public class ProductVM
    {
        public int Id { get; set; }


        public string ProductName { get; set; }


        public decimal Price { get; set; }
        public string? Description { get; set; }
    }
}
