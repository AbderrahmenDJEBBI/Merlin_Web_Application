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
    
    public partial class DiscountsReport_Result
    {
        public string CustRef { get; set; }
        public string CustomerName { get; set; }
        public int InvoiceNumber { get; set; }
        public Nullable<System.DateTime> DateOfDiscount { get; set; }
        public string Description { get; set; }
        public int Goods { get; set; }
        public int VAT { get; set; }
        public Nullable<decimal> Total { get; set; }
        public int sortseq { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
    }
}
