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
    
    public partial class OrderHistory_Result
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public System.DateTime OrderDate { get; set; }
        public string DealTypeID { get; set; }
        public string CustomerOrderReference { get; set; }
        public bool Collection { get; set; }
        public string HaulierID { get; set; }
        public string OrderStatusID { get; set; }
        public string VATTypeID { get; set; }
        public string CurrencyID { get; set; }
        public string CollectionReference { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Transport { get; set; }
        public decimal VAT { get; set; }
        public decimal OrderTotal { get; set; }
        public Nullable<decimal> DiscountPercent { get; set; }
        public decimal DiscountValue { get; set; }
        public Nullable<System.DateTime> EarlyDiscountPaymentDate { get; set; }
        public string DiscountType { get; set; }
        public Nullable<decimal> DiscountApplied { get; set; }
        public string DispatchMethodID { get; set; }
        public string OrderNotes { get; set; }
        public Nullable<System.DateTime> DateCancelled { get; set; }
        public string CancellationReasonID { get; set; }
        public string CancellationNote { get; set; }
        public string OrderIssues { get; set; }
        public Nullable<int> AddressID { get; set; }
        public Nullable<int> DealNumber { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public bool Release { get; set; }
        public string Reg { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public string SupplierDepotID { get; set; }
        public string OrderStatusID1 { get; set; }
        public string OrderStatusName { get; set; }
    }
}
