using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECA.DataTransferObjects
{
    
    public class BookDTO
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string AuthorId { get; set; }
        public string GenreId { get; set; }
        public string CategoryId { get; set; }
        public string ISBN { get; set; }

        public AuthorDTO Author { get; set; }
        public BookCategoryDTO BookCategory { get; set; }
        public GenreDTO Genre { get; set; }
    }
    public class BookCategoryDTO
    {
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
    public  class AuthorDTO
    {
        public string AuthorId { get; set; }
        public string AuthorName { get; set; }
    }
    public partial class GenreDTO
    {
        public string GenreId { get; set; }
        public string GenreName { get; set; }
    }
}
