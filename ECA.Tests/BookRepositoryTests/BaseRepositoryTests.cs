using ECA.BusinessLayer.SQL;
using ECA.Model;
using ECA.Model.Fakes;
using ECA.Repository;
using ECA.Repository.SQL;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.Entity.Fakes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Caching;

namespace ECA.Tests.BookRepositoryTests
{
    public abstract class BaseRepositoryTests<T> where T : SQLBaseRepository,new()
    {
        protected static IDisposable shimContext;
        public BaseRepositoryTests()
        {
            //using (ShimsContext.Create())
            //{
                shimContext = ShimsContext.Create();
                ShimECAEntities.Constructor = @this => TestInit.InitTestDBContext(@this);
                ShimDbContext.AllInstances.SaveChanges = context => 1;
                _repository = GetOrCreateRepository();
            //}
        }
    
        protected T _repository;
       
        [ClassCleanup]
        protected static void ClassCleanup()
        {
            shimContext.Dispose();
        }
        protected  T GetOrCreateRepository()
        {
            CacheDependency dep = new CacheDependency(@"C:\Users\jagmeet_chaudhary\Documents\Visual Studio 2010\Projects\ECA.BusinessLayer\ECA.Tests\TestData.xlsx");

            if (HttpRuntime.Cache[GetRepositoryCacheKey()] == null || dep.HasChanged)
            {
                _repository = GetRepository();
                HttpRuntime.Cache[GetRepositoryCacheKey()] = _repository;
                return _repository;
            }
            else
            {
                return HttpRuntime.Cache[GetRepositoryCacheKey()] as T;
            }
        }

        protected abstract T GetRepository();
        protected abstract string GetRepositoryCacheKey();
       
    }
}
