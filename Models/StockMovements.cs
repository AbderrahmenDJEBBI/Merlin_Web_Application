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
    
    public partial class StockMovements
    {
        public int StockMovementID { get; set; }
        public string StockMovementTypeID { get; set; }
        public string ProductID { get; set; }
        public string SupplierID { get; set; }
        public string Reference { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<int> Pallets { get; set; }
        public Nullable<int> ItemsPerPallet { get; set; }
        public string Comments { get; set; }
        public System.DateTime MovementDate { get; set; }
        public bool Deleted { get; set; }
        public string DeliveredOrCollected { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
        public virtual StockMovementType StockMovementType { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
