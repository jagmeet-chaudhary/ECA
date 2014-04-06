//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ECA.Model
{
    using System;
    using System.Collections.Generic;
    
     using System.Runtime.Serialization;
    [DataContract(Name="Book",IsReference=true)] 
    public partial class Book
    {
    	
        public Book()
        {
    		
            this.Carts = new HashSet<Cart>();
        }
    
    	[DataMember(Name="ID")]
        public string ID { get; set; }
    	[DataMember(Name="Title")]
        public string Title { get; set; }
    	[DataMember(Name="Description")]
        public string Description { get; set; }
    	[DataMember(Name="AuthorId")]
        public string AuthorId { get; set; }
    	[DataMember(Name="GenreId")]
        public string GenreId { get; set; }
    	[DataMember(Name="CategoryId")]
        public string CategoryId { get; set; }
    	[DataMember(Name="ISBN")]
        public string ISBN { get; set; }
    	[DataMember(Name="ImageUrl")]
        public string ImageUrl { get; set; }
    	[DataMember(Name="Price")]
        public Nullable<decimal> Price { get; set; }
    
    [DataMember(Name="Author")]
        public virtual Author Author { get; set; }
    [DataMember(Name="BookCategory")]
        public virtual BookCategory BookCategory { get; set; }
    [DataMember(Name="Genre")]
        public virtual Genre Genre { get; set; }
    [DataMember(Name="Carts")]
        public virtual ICollection<Cart> Carts { get; set; }
    }
}
