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
    
    public partial class ShipmentItem
    {
        public int ShipmentItemID { get; set; }
        public Nullable<int> QtyPicked { get; set; }
        public Nullable<int> QtyDelivered { get; set; }
        public Nullable<int> ItemPerPallet { get; set; }
        public Nullable<int> PltsPicked { get; set; }
        public Nullable<int> InvoiceLineID { get; set; }
    
        public virtual InvoiceDetail InvoiceDetail { get; set; }
    }
}
