using FluentValidation;
using FluentValidationPractice_MVC.ViewModels;

namespace FluentValidationPractice_MVC.FluentValidators
{
    public class ProductVMValidator : AbstractValidator<ProductVM>
    {
        public ProductVMValidator()
        {
            RuleFor(x => x.ProductName)
                .NotEmpty().WithMessage("Ürün adı boş bırakılamaz!")
                .MinimumLength(3).WithMessage("Ürün Adı en az 3 karakter uzunluğunda olmalıdır")
                .MaximumLength(255).WithMessage("Ürün Adı en fazla 255 karakter uzunluğunda olmalıdır");

            RuleFor(x => x.Price)
                  .GreaterThanOrEqualTo(1).WithMessage("Ürün Fiyat 1 veya daha büyük olmalıdır");

        }


    }

        
    }


