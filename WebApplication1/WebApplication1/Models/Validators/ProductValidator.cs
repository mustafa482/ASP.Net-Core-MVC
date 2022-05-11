using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Validators
{
    public class ProductValidator: AbstractValidator<Product>
    {

        public ProductValidator()
        {
            RuleFor(x => x.Email).NotNull().WithMessage("Email bos olamaz");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Email dogru girilmeyib");

            RuleFor(x => x.ProductName).NotEmpty().WithMessage("ProductName bos olmaz");
        }

    }
}
