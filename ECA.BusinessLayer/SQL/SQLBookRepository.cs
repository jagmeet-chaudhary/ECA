using ECA.BusinessLayer.SQL;
using ECA.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ECA.Repository.SQL
{
    public class SQLBookRepository : SQLBaseRepository, IBookRepository
    {
        public SQLBookRepository() : base()
        {
        }
        public SQLBookRepository(ECAEntities _DB) : base(_DB)
        {
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


        public IQueryable<BookCategory> GetAllBooksGroupedByCategory()
        {
            return Db.BookCategories.Include(bc => bc.Books);
            
        }
    }
}
