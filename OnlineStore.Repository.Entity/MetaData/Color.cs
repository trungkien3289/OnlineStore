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
    
    public partial class Color
    {
        public Color()
        {
            this.ProductTitles = new HashSet<ProductTitle>();
        }
    
        public int ColorId { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<ProductTitle> ProductTitles { get; set; }
    }
}
