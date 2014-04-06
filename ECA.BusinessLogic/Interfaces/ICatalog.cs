using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ECA.Model;

namespace ECA.BusinessLogic
{
    public interface ICatalog
    {
        Book GetBookById(string id);
        IList<Book> GetAllBooks();
        IList<Book> GetBooksByCategory(string  categoryId);
        IList<Book> GetBooksByGenre(string genreId);
        IList<BookCategory> GetAllCategories();
        IList<Genre> GetAllGenre();
        IList<BookCategory> GetAllBooksGroupedByCategory();
    }
}
