using Apartment.Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Bll.ValidationRules
{
    public class BuildingValidator : AbstractValidator<Building>
    {
        public BuildingValidator()
        {
          
            

            RuleFor(x => x.Name).NotEmpty().WithMessage("Apartman adı boş olmamalıdır.");
            RuleFor(x => x.Name).MinimumLength(4).WithMessage("Apartman adı en az 4 karakterli olmalıdır.");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Apartman adı en fazla 30 karakterli olmalıdır.");


            RuleFor(x => x.City).NotEmpty().WithMessage("İl seçiniz!");

            RuleFor(x => x.County).NotEmpty().WithMessage("İlçe seçiniz!");
         
            RuleFor(x => x.Heating).NotEmpty().WithMessage("Isınma türü seçiniz!");

            RuleFor(x => x.address).NotEmpty().WithMessage("Adres boş olmamalıdır.");
            RuleFor(x => x.address).MinimumLength(15).WithMessage("Adres en az 15 karakterli olmalıdır.");
            RuleFor(x => x.address).MaximumLength(120).WithMessage("Adres en fazla 120 karakterli olmalıdır.");


        }

    }
}
