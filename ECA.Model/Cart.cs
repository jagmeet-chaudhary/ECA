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
    [DataContract(Name="Cart",IsReference=true)] 
    public partial class Cart
    {
    	[DataMember(Name="ItemCode")]
        public string ItemCode { get; set; }
    	[DataMember(Name="Quantity")]
        public int Quantity { get; set; }
    	[DataMember(Name="UserId")]
        public int UserId { get; set; }
    
    [DataMember(Name="Book")]
        public virtual Book Book { get; set; }
    [DataMember(Name="User")]
        public virtual User User { get; set; }
    }
}
