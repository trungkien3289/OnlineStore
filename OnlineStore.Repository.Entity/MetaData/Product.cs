//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineStore.Repository.Entity.MetaData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int ProductId { get; set; }
        public int SizeId { get; set; }
        public int ProductTitleId { get; set; }
    
        public virtual ProductTitle ProductTitle { get; set; }
        public virtual Size Size { get; set; }
    }
}
