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
    
    public partial class PalletMovementsReport_Result
    {
        public string CustomerRef { get; set; }
        public string CustomerName { get; set; }
        public string ProductID { get; set; }
        public Nullable<int> Issued { get; set; }
        public Nullable<int> Returned { get; set; }
        public Nullable<int> Balance { get; set; }
        public Nullable<int> Refunded { get; set; }
        public Nullable<int> BoughtIn { get; set; }
        public Nullable<int> WriteOnOff { get; set; }
        public Nullable<int> TransferredInOut { get; set; }
        public Nullable<int> Owing { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
    }
}
