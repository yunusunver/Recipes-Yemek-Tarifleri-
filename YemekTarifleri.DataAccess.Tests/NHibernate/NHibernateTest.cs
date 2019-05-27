using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YemekTarifleri.DataAccess.Concrete.NHibernate;
using YemekTarifleri.DataAccess.Concrete.NHibernate.Helpers;

namespace YemekTarifleri.DataAccess.Tests.NHibernate
{
    [TestClass]
    public class NHibernateTest
    {
        [TestMethod]
        public void Get_all_returns_all_categories()
        {
            NhCategoryDal categoryDal=new NhCategoryDal(new SqlServerHelper());

            var result = categoryDal.GetList();

            Assert.AreEqual(4,result.Count);
        }
    }
}
