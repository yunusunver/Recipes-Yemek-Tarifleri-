using Microsoft.VisualStudio.TestTools.UnitTesting;
using YemekTarifleri.DataAccess.Concrete.EntityFramework;

namespace YemekTarifleri.DataAccess.Tests.EntityFramework
{
    [TestClass]
    public class EntityFrameworkTest
    {
        [TestMethod]
        public void Get_all_returns_all_categories()
        {
            EfCategoryDal categoryDal=new EfCategoryDal();
            var result=categoryDal.GetList();

            Assert.AreEqual(4,result.Count);
        }

        [TestMethod]
        public void Get_all_with_returns_filtered_categories()
        {
            EfCategoryDal categoryDal = new EfCategoryDal();
            var result = categoryDal.GetList(x=>x.CategoryName.Contains("salata"));

            Assert.AreEqual(1, result.Count);
        }
    }
}
