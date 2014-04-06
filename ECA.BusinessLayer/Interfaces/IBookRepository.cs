using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using ECA.Model;

namespace ECA.Repository
{
    public interface IBookRepository
    {
        
         ECAEntities Db { get; set; }
        IQueryable<Book> GetBooks();
        IQueryable<BookCategory> GetCategories();
        IQueryable<Author> GetAuthors();
        IQueryable<Genre> GetGenres();
        IQueryable<BookCategory> GetAllBooksGroupedByCategory();
    }
}
