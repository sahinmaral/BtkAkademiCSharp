using FluentValidation;

using Northwind.Entities.Concrete;

namespace Northwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().NotNull().WithMessage("Ürün adı boş bırakılamaz");
            RuleFor(x => x.CategoryId).NotEmpty().NotNull().WithMessage("Kategori boş bırakılamaz");
            RuleFor(x => x.UnitPrice).NotEmpty().NotNull().WithMessage("Birim fiyatı boş bırakılamaz");
            RuleFor(x => x.QuantityPerUnit).NotEmpty().NotNull().WithMessage("Birim adedi boş bırakılamaz");
            RuleFor(x => x.UnitsInStock).NotEmpty().NotNull().WithMessage("Stok adedi boş bırakılamaz");

            RuleFor(x => x.UnitPrice).GreaterThan(0);
            RuleFor(x => x.UnitsInStock).GreaterThan((short)0);

        }
    }
}
