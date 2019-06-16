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
            RuleFor(x => x.CookingTime).NotEmpty();
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.Image).NotEmpty();
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.PersonQuantity).NotEmpty();
            RuleFor(x => x.PreparationTime).NotEmpty();
        }
    }
}
