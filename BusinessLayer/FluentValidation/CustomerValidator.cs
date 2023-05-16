using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator() ////constructor olmadan RuleFor komutu çalışmaz !
        {
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir bilgisi boş geçilemez.");
            RuleFor(x => x.CustomerName).NotEmpty().WithMessage("İsim boş geçilemez.");
        }
    }
}
