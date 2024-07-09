using FluentValidation;

namespace ilkProje.Models.Validators
{
    public class ProductValidator:AbstractValidator<Product>
    {
        
        public ProductValidator() {

            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün ismi boş olamaz!").NotNull().WithMessage("Ürün ismi boş olamaz!");
            RuleFor(x => x.Quanity).NotNull().WithMessage("Miktar boş olamaz!").NotEmpty().WithMessage("Ürün ismi boş olamaz!");
            RuleFor(x => x.Id).NotNull().WithMessage("Ürün id boş olamaz!").NotEmpty().WithMessage("Ürün ismi boş olamaz!");

        }   

    }
}
