using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using YemekTarifleri.Entities.Concrete;

namespace YemekTarifleri.Business.ValidationRules.FluentValidation
{
    public class MealValidator:AbstractValidator<Meal>
    {
        public MealValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
