//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Merlin_web_Application.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class StockType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StockType()
        {
            this.ProductGroup = new HashSet<ProductGroup>();
        }
    
        public string StockTypeID { get; set; }
        public string StockTypeName { get; set; }
        public bool AllowDiscount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductGroup> ProductGroup { get; set; }
    }
}
