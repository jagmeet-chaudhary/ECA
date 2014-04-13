using AutoMapper;
using ECA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECA.Web.ViewModel
{
    public class CategoryViewModel : BaseViewModel 
    {
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<ProductViewModel> Books { get; set; }
    }
    public class CategoryViewModelBuilder
    {
        BookCategory _model;
        public CategoryViewModelBuilder(BookCategory model)
        {
            Mapper.CreateMap<BookCategory, CategoryViewModel>();
            Mapper.CreateMap<Book, ProductViewModel>();
            _model = model;
        }
        public CategoryViewModel Build()
        {
            return Mapper.Map<BookCategory, CategoryViewModel>(_model);
        }
    }
}