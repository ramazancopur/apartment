using Apartment.Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Bll.ValidationRules
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adı bilgisi boş olmamalıdır.");
            RuleFor(x => x.UserName).MinimumLength(4).WithMessage("Kullanıcı adı en az 4 karakterli olmalıdır.");
            RuleFor(x => x.UserName).MaximumLength(20).WithMessage("Kullanıcı adı en fazla 20 karakterli olmalıdır.");

            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre boş olmamalıdır.");
            RuleFor(x => x.Password).MinimumLength(4).WithMessage("Şifre en az 4 karakterli olmalıdır.");
            RuleFor(x => x.Password).MaximumLength(20).WithMessage("Şifre en fazla 20 karakterli olmalıdır.");
            
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad bilgisi boş olmamalıdır.");
            RuleFor(x => x.Name).MinimumLength(4).WithMessage("Soyad en az 4 karakterli olmalıdır.");
            RuleFor(x => x.Name).MaximumLength(20).WithMessage("Soyad en fazla 20 karakterli olmalıdır.");

            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad bilgisi boş olmamalıdır.");
            RuleFor(x => x.Surname).MinimumLength(4).WithMessage("Soyad en az 4 karakterli olmalıdır.");
            RuleFor(x => x.Surname).MaximumLength(20).WithMessage("Soyad en fazla 20 karakterli olmalıdır.");

            RuleFor(x => x.Email).EmailAddress().WithMessage("Geçerli bir email adresi giriniz.");

        }
    }
}
