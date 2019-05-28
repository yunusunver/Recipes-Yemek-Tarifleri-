using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using FluentValidation;
using YemekTarifleri.Business.Concrete.Managers;
using YemekTarifleri.DataAccess.Abstract;
using YemekTarifleri.Entities.Concrete;

namespace YemekTarifleri.Business.Tests
{
    [TestClass]
    public class CategoryManagerTests
    {
        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void Category_validation_check()
        {
            Mock<ICategoryDal> mock = new Mock<ICategoryDal>();
            CategoryManager categoryManager = new CategoryManager(mock.Object);

            categoryManager.Add(new Category());
        }
    }
}
