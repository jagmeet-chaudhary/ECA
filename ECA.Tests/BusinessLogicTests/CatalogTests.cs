using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ECA.Repository;
using ECA.Repository.SQL;
using ECA.BusinessLogic;
using ECA.Model;
using ECA.Tests.BookRepositoryTests;
using Microsoft.QualityTools.Testing.Fakes;
using ECA.Model.Fakes;
using ECA.Repository.Fakes;
using ECA.Repository.SQL.Fakes;
using System.Linq;
using System.Collections.Generic;
using Microsoft.Practices.Unity;
using ECA.Tests.TestingMocks;
using ECA.BusinessLayer.Interfaces;

namespace ECA.Tests.BusinessLogicTests
{
    [TestClass]
    public class CatalogTests : BaseBusinessLogicTests
    {
        
        public static  ICatalog ProductCatalog { get; set; }
        public CatalogTests()
        {
            
        }
        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            container.RegisterType<IBookRepository, BookRepositoryMock>();
            ProductCatalog = container.Resolve<Catalog>();
                     
        }   
        [ClassCleanup]
        public static void ClassCleanup()
        {
            container.Teardown(ProductCatalog);
        }
        [TestMethod]
        public  void GetAllBooks_return_all_books()
        {
            var books = ProductCatalog.GetAllBooks();
            Assert.IsTrue(books.Count().Equals(3));
        }
        [TestMethod]
        public void GetBooksByCategory_return_correct_books()
        {
            var books = ProductCatalog.GetBooksByCategory("CATE1");
            Assert.IsTrue(books.Count().Equals(3));
        }
        [TestMethod]
        public void GetBooksByCategory_return_correct_genre()
        {
            var books = ProductCatalog.GetBooksByGenre("GENR1");
            Assert.IsTrue(books.Count().Equals(3));
        }
        [TestMethod]
        public void GetAllGenre_return_all_genre()
        {
            var genre = ProductCatalog.GetAllGenre();
            Assert.IsTrue(genre.Count().Equals(1));
        }

        [TestMethod]
        public void GetAllCategories_return_all_categories()
        {
            var categories = ProductCatalog.GetAllCategories();
            Assert.IsTrue(categories.Count().Equals(1));
        }
        [TestMethod]
        public void GetAllBooksGroupedByCategory_return_all_books()
        {
            var categories = ProductCatalog.GetAllBooksGroupedByCategory();
            Assert.IsTrue(categories.Count().Equals(1));
            Assert.IsTrue(categories.Where(c => c.CategoryId  == "CATE1").FirstOrDefault().Books.FirstOrDefault().ID == "BOOK1");
        }
        [TestMethod]
        public void GetBookById_Returns_Correct_book()
        {
            var book = ProductCatalog.GetBookById("BOOK1");
            Assert.IsTrue(book.Title == "A Search in secret india");
        }
        
    }
}
