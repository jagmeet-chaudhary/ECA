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
    [DataContract(Name="User",IsReference=true)] 
    public partial class User
    {
    	
        public User()
        {
    		
            this.Carts = new HashSet<Cart>();
    		
            this.webpages_Roles = new HashSet<webpages_Roles>();
        }
    
    	[DataMember(Name="UserId")]
        public int UserId { get; set; }
    	[DataMember(Name="UserName")]
        public string UserName { get; set; }
    	[DataMember(Name="FirstName")]
        public string FirstName { get; set; }
    	[DataMember(Name="LastName")]
        public string LastName { get; set; }
    	[DataMember(Name="Email")]
        public string Email { get; set; }
    
    [DataMember(Name="Carts")]
        public virtual ICollection<Cart> Carts { get; set; }
    [DataMember(Name="webpages_Roles")]
        public virtual ICollection<webpages_Roles> webpages_Roles { get; set; }
    }
}