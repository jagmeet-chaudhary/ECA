using ECA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ECA.Web.ViewModel
{
    public class ProductViewModel : BaseViewModel 
    {
        public string Title { get; set; }
        public string Description { get; set; }
        [DisplayName("Author")]
        public string AuthorName { get; set; }
        [DisplayName("Category")]
        public string CategoryName { get; set; }
        [DisplayName("Genre")]
        public string GenreName { get; set; }
        public string ISBN { get; set; }
        public string ImageUrl { get; set; }

    }
    public class ProductViewModelBuilder
    {
        Book _model;
        public ProductViewModelBuilder(Book model)
        {
            Mapper.CreateMap<Book, ProductViewModel>();
            _model = model;
        }
        public ProductViewModel Build()
        {
            return Mapper.Map<Book, ProductViewModel>(_model);
        }
    }

 

}