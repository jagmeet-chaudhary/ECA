using ECA.Model;
using ECA.Repository;
using ECA.Repository.SQL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ECA.BusinessLogic
{
    public class Catalog : ICatalog
    {
        private IBookRepository _repository;

        //public Catalog()
        //{
        //    _repository = new SQLBookRepository();
        //}
        public Catalog(IBookRepository repository)
        {
            _repository = repository;
        }
        public Book GetBookById(string id)
        {
            return _repository.GetBooks().Where(book => book.ID == id).FirstOrDefault();
        }
        public IList<Model.Book> GetAllBooks()
        {
            return _repository.GetBooks().ToList<Model.Book>();
        }

        public IList<Model.Book> GetBooksByCategory(string categoryId)
        {
            return _repository.GetBooks().Where(b => b.CategoryId.ToUpper() == categoryId.ToUpper()).ToList<Model.Book>();
        }
        public IList<Model.Book> GetBooksByGenre(string genreId)
        {
            return _repository.GetBooks().Where(b => b.GenreId.ToUpper() == genreId.ToUpper()).ToList<Model.Book>();
        }
        public IList<Model.BookCategory> GetAllCategories()
        {
            return _repository.GetCategories().ToList<Model.BookCategory>();
        }

        public IList<Model.Genre> GetAllGenre()
        {
            return _repository.GetGenres().ToList<Model.Genre>();
        }
        public IList<Model.BookCategory> GetAllBooksGroupedByCategory()
        {
            return _repository.GetAllBooksGroupedByCategory().ToList<BookCategory>(); ;
            
        }
    }
   
}
