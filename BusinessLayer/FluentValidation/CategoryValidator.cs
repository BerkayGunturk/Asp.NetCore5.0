using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator() //constructor olmadan RuleFor komutu çalışmaz !
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori ad boş geçilemez.");
        }
    }
}
