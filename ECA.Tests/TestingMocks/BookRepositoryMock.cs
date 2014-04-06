using ECA.Repository;
using ECA.Repository.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.Web.Caching;
using System.Web;
using ECA.Model;

namespace ECA.Tests.TestingMocks
{
    public class BookRepositoryMock : IBookRepository
    {

        public BookRepositoryMock()
        {

        }
        public Model.ECAEntities Db
        {
            get
            {
                CacheDependency dep = new CacheDependency(@"C:\Users\jagmeet_chaudhary\Documents\Visual Studio 2010\Projects\ECA.BusinessLayer\ECA.Tests\TestData.xlsx");

                if (HttpRuntime.Cache["Db"] == null || dep.HasChanged)
                {
                    HttpRuntime.Cache["Db"] = TestInit.MockDb;
                }
                return HttpRuntime.Cache["Db"] as ECAEntities;
            }
            set
            {
            }
            
        }

        public IQueryable<Model.Book> GetBooks()
        {
            return Db.Books.AsQueryable();
        }

        public IQueryable<Model.BookCategory> GetCategories()
        {
            return Db.BookCategories.AsQueryable();
        }

        public IQueryable<Model.Author> GetAuthors()
        {
            return Db.Authors.AsQueryable();
        }

        public IQueryable<Model.Genre> GetGenres()
        {
            return Db.Genres.AsQueryable();
        }

        public IQueryable<Model.BookCategory> GetAllBooksGroupedByCategory()
        {
            BookCategory category = new BookCategory()
            {
                CategoryId = "CATE1",
                CategoryName = "Category 1",
                Books = new List<Book>()
                {
                    new Book() { ID = "BOOK1"},
                    new Book() { ID = "BOOK2"}
                }
            };

            return  new List<BookCategory>()
            {
                category 
            }.AsQueryable();
        }
    }
}
         