using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ECA.Repository;
using ECA.Model.Fakes;
using ECA.Repository.SQL;
using ECA.Repository.Fakes;
using ECA.Repository.SQL.Fakes;
using Microsoft.QualityTools.Testing.Fakes;
using System.Data.Entity;
using System.Data.Entity.Fakes;
using System.Data.Entity.Infrastructure;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Web.Caching;

using ECA.Model;
using System.Web;


namespace ECA.Tests.BookRepositoryTests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class SQLBookRepositoryTests :BaseRepositoryTests<SQLBookRepository>
    {

        #region Category tests
        [TestMethod]
        public void GetCategories_Return_all_categories_in_db()
        {
            var categories = _repository.GetCategories();
            
            Assert.IsTrue(categories.Count().Equals(1));
        }
        [TestMethod]
        public void GetCategories_Return_categories_with_correct_values()
        {
            var categories = _repository.GetCategories().FirstOrDefault();
           
            Assert.IsTrue(
               categories.CategoryId  == "CATE1" &&
               categories.CategoryName  == "Philosophy" 
              );
        }
        [TestMethod]
        public void GetAllBooksGroupedByCategory_return_correct_data()
        {
            var categories = _repository.GetAllBooksGroupedByCategory();

            Assert.IsTrue(categories.Count().Equals(1),"Category count incorrect");
            Assert.IsTrue(categories.FirstOrDefault().Books.Count().Equals(3),"Books count incorrect");
            Assert.IsTrue(categories.Where(c => c.CategoryName == "CATE1").FirstOrDefault().Books.FirstOrDefault().ID == "BOOK1", "Books value incorrect");
        }
        #endregion

        #region Book tests
        [TestMethod]
        public void GetBooks_Return_all_books_in_db()
        {
            var books = _repository.GetBooks();
            Assert.IsTrue(books.Count().Equals(3));
        }
        [TestMethod]
        public void GetBooks_return_books_with_correct_category()
        {
            Model.Book book = _repository.GetBooks().FirstOrDefault();
            var catName = _repository.GetCategories().Where(c=>c.CategoryId == book.CategoryId).FirstOrDefault().CategoryName ;
            Assert.IsTrue(catName == "Philosophy");
        }
        [TestMethod]
        public void GetBooks_return_books_with_correct_genre()
        {
            Model.Book book = _repository.GetBooks().FirstOrDefault();
            var genName = _repository.GetGenres().Where(g => g.GenreId == book.GenreId).FirstOrDefault().GenreName ;
            Assert.IsTrue(genName == "Non Fiction");
        }
        [TestMethod]
        public void GetBooks_return_books_with_correct_Author()
        {
            Model.Book book = _repository.GetBooks().FirstOrDefault();
            var authName = _repository.GetAuthors().Where(a=>a.AuthorId == book.AuthorId).FirstOrDefault().AuthorName;
            Assert.IsTrue(authName == "Jagmeet Singh");
        }
        [TestMethod]
        public void GetBooks_Retun_books_with_Correct_property()
        {
            var book = _repository.GetBooks().FirstOrDefault();
            Assert.IsTrue(
                book.AuthorId == "AUTH1" &&
                book.CategoryId == "CATE1" &&
                book.Description == "A Search in secret india" &&
                book.Title == "A Search in secret india" &&
                book.GenreId == "GENR1" &&
                book.ID == "BOOK1" &&
                book.ISBN == "ISBN1439056501");

        }
        #endregion

        #region Author tests
        [TestMethod]
        public void GetAuthors_Return_all_authors_in_db()
        {
            var authors = _repository.GetAuthors();
            Assert.IsTrue(authors.Count().Equals(1));
        }
        [TestMethod]
        public void GetAuthors_Return_authors_with_correct_values()
        {
            var authors = _repository.GetAuthors().FirstOrDefault();
            Assert.IsTrue(
               authors.AuthorId  == "AUTH1" &&
               authors.AuthorName == "Jagmeet Singh"
              );
        }
        #endregion

        #region Genre Tests
        [TestMethod]
        public void GetGenre_Return_all_genres_in_db()
        {
            var genre = _repository.GetGenres();
            Assert.IsTrue(genre.Count().Equals(1));
        }
        [TestMethod]
        public void GetGenre_Return_genres_with_correct_values()
        {
            var genre = _repository.GetGenres().FirstOrDefault();
            Assert.IsTrue(
               genre.GenreId  == "GENR1" &&
               genre.GenreName == "Non Fiction"
              );
        }
        #endregion


        protected override SQLBookRepository GetRepository()
        {
            return new SQLBookRepository(new ECAEntities());
        }


        protected override string GetRepositoryCacheKey()
        {
            return "BookRepository";
        }
    }
}
