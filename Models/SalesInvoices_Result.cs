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
    
    public partial class SalesInvoices_Result
    {
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> Todate { get; set; }
        public int InvoiceNumber { get; set; }
        public string CustomerRef { get; set; }
        public string DateofInvoice { get; set; }
        public string Description { get; set; }
        public int VATCode { get; set; }
        public Nullable<decimal> VATAmount { get; set; }
        public Nullable<decimal> InvoiceTotal { get; set; }
        public Nullable<decimal> PaymentAmount { get; set; }
        public string PaidOn { get; set; }
    }
}
