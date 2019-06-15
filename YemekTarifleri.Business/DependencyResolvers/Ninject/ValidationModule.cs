using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Ninject.Modules;
using YemekTarifleri.Business.ValidationRules.FluentValidation;
using YemekTarifleri.Entities.Concrete;

namespace YemekTarifleri.Business.DependencyResolvers.Ninject
{
    public class ValidationModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Category>>().To<CategoryValidator>();
            Bind<IValidator<Meal>>().To<MealValidator>();
        }
    }
}
