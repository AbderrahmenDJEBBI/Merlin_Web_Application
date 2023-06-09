﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Merlin_DataEntities : DbContext
    {
        public Merlin_DataEntities()
            : base("name=Merlin_DataEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AccessGroup> AccessGroup { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AddressType> AddressType { get; set; }
        public virtual DbSet<CancellationReason> CancellationReason { get; set; }
        public virtual DbSet<Colour> Colour { get; set; }
        public virtual DbSet<Credit> Credit { get; set; }
        public virtual DbSet<CreditReason> CreditReason { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerGroup> CustomerGroup { get; set; }
        public virtual DbSet<CustomerType> CustomerType { get; set; }
        public virtual DbSet<DealNumber> DealNumber { get; set; }
        public virtual DbSet<DealType> DealType { get; set; }
        public virtual DbSet<DispatchMethod> DispatchMethod { get; set; }
        public virtual DbSet<Feature> Feature { get; set; }
        public virtual DbSet<Haulier> Haulier { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetail { get; set; }
        public virtual DbSet<InvoiceStatus> InvoiceStatus { get; set; }
        public virtual DbSet<InvoiceType> InvoiceType { get; set; }
        public virtual DbSet<NeckFinish> NeckFinish { get; set; }
        public virtual DbSet<OldPasswords> OldPasswords { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        public virtual DbSet<OrderStatus> OrderStatus { get; set; }
        public virtual DbSet<PalletMovement> PalletMovement { get; set; }
        public virtual DbSet<PalletMovementType> PalletMovementType { get; set; }
        public virtual DbSet<PartielCredit> PartielCredit { get; set; }
        public virtual DbSet<PasswordPolicy> PasswordPolicy { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<PaymentAllocation> PaymentAllocation { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethod { get; set; }
        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<PriceList> PriceList { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductGroup> ProductGroup { get; set; }
        public virtual DbSet<Shipment> Shipment { get; set; }
        public virtual DbSet<ShipmentItem> ShipmentItem { get; set; }
        public virtual DbSet<ShipmentStatus> ShipmentStatus { get; set; }
        public virtual DbSet<Size> Size { get; set; }
        public virtual DbSet<Stock> Stock { get; set; }
        public virtual DbSet<StockComments> StockComments { get; set; }
        public virtual DbSet<StockMovements> StockMovements { get; set; }
        public virtual DbSet<StockMovementType> StockMovementType { get; set; }
        public virtual DbSet<StockType> StockType { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<SupplierDepot> SupplierDepot { get; set; }
        public virtual DbSet<TempStatements> TempStatements { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<VATRate> VATRate { get; set; }
        public virtual DbSet<VATType> VATType { get; set; }
        public virtual DbSet<weight> weight { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Company> Company { get; set; }
    
        public virtual ObjectResult<AgeListing_Result> AgeListing(Nullable<System.DateTime> baldate)
        {
            var baldateParameter = baldate.HasValue ?
                new ObjectParameter("Baldate", baldate) :
                new ObjectParameter("Baldate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AgeListing_Result>("AgeListing", baldateParameter);
        }
    
        public virtual ObjectResult<AgeListing_old_Result> AgeListing_old(Nullable<System.DateTime> baldate)
        {
            var baldateParameter = baldate.HasValue ?
                new ObjectParameter("Baldate", baldate) :
                new ObjectParameter("Baldate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AgeListing_old_Result>("AgeListing_old", baldateParameter);
        }
    
        public virtual ObjectResult<AgeListing_old2_Result> AgeListing_old2(Nullable<System.DateTime> baldate)
        {
            var baldateParameter = baldate.HasValue ?
                new ObjectParameter("Baldate", baldate) :
                new ObjectParameter("Baldate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AgeListing_old2_Result>("AgeListing_old2", baldateParameter);
        }
    
        public virtual ObjectResult<CreditsReport_Result> CreditsReport(Nullable<System.DateTime> from, Nullable<System.DateTime> to)
        {
            var fromParameter = from.HasValue ?
                new ObjectParameter("From", from) :
                new ObjectParameter("From", typeof(System.DateTime));
    
            var toParameter = to.HasValue ?
                new ObjectParameter("To", to) :
                new ObjectParameter("To", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CreditsReport_Result>("CreditsReport", fromParameter, toParameter);
        }
    
        public virtual ObjectResult<Current_Result> Current(Nullable<int> cust, Nullable<System.DateTime> balDate, Nullable<bool> oSMonth1)
        {
            var custParameter = cust.HasValue ?
                new ObjectParameter("Cust", cust) :
                new ObjectParameter("Cust", typeof(int));
    
            var balDateParameter = balDate.HasValue ?
                new ObjectParameter("BalDate", balDate) :
                new ObjectParameter("BalDate", typeof(System.DateTime));
    
            var oSMonth1Parameter = oSMonth1.HasValue ?
                new ObjectParameter("OSMonth1", oSMonth1) :
                new ObjectParameter("OSMonth1", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Current_Result>("Current", custParameter, balDateParameter, oSMonth1Parameter);
        }
    
        public virtual ObjectResult<CustomerHistory_Result> CustomerHistory(Nullable<int> cust)
        {
            var custParameter = cust.HasValue ?
                new ObjectParameter("Cust", cust) :
                new ObjectParameter("Cust", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CustomerHistory_Result>("CustomerHistory", custParameter);
        }
    
        public virtual ObjectResult<CustomerReport_Result> CustomerReport(Nullable<int> custID, Nullable<int> year, Nullable<int> month)
        {
            var custIDParameter = custID.HasValue ?
                new ObjectParameter("CustID", custID) :
                new ObjectParameter("CustID", typeof(int));
    
            var yearParameter = year.HasValue ?
                new ObjectParameter("Year", year) :
                new ObjectParameter("Year", typeof(int));
    
            var monthParameter = month.HasValue ?
                new ObjectParameter("Month", month) :
                new ObjectParameter("Month", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CustomerReport_Result>("CustomerReport", custIDParameter, yearParameter, monthParameter);
        }
    
        public virtual ObjectResult<DaySheet_Result> DaySheet(Nullable<System.DateTime> day)
        {
            var dayParameter = day.HasValue ?
                new ObjectParameter("Day", day) :
                new ObjectParameter("Day", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DaySheet_Result>("DaySheet", dayParameter);
        }
    
        public virtual int DeleteAllStatements()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteAllStatements");
        }
    
        public virtual ObjectResult<DeliveriesReport_Result> DeliveriesReport(Nullable<int> custID, Nullable<int> year, Nullable<int> month)
        {
            var custIDParameter = custID.HasValue ?
                new ObjectParameter("CustID", custID) :
                new ObjectParameter("CustID", typeof(int));
    
            var yearParameter = year.HasValue ?
                new ObjectParameter("Year", year) :
                new ObjectParameter("Year", typeof(int));
    
            var monthParameter = month.HasValue ?
                new ObjectParameter("Month", month) :
                new ObjectParameter("Month", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DeliveriesReport_Result>("DeliveriesReport", custIDParameter, yearParameter, monthParameter);
        }
    
        public virtual ObjectResult<DeliveriesReport2_Result> DeliveriesReport2(Nullable<int> custID, Nullable<int> year, Nullable<int> month)
        {
            var custIDParameter = custID.HasValue ?
                new ObjectParameter("CustID", custID) :
                new ObjectParameter("CustID", typeof(int));
    
            var yearParameter = year.HasValue ?
                new ObjectParameter("Year", year) :
                new ObjectParameter("Year", typeof(int));
    
            var monthParameter = month.HasValue ?
                new ObjectParameter("Month", month) :
                new ObjectParameter("Month", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DeliveriesReport2_Result>("DeliveriesReport2", custIDParameter, yearParameter, monthParameter);
        }
    
        public virtual ObjectResult<DiscountsReport_Result> DiscountsReport(Nullable<System.DateTime> from, Nullable<System.DateTime> to)
        {
            var fromParameter = from.HasValue ?
                new ObjectParameter("From", from) :
                new ObjectParameter("From", typeof(System.DateTime));
    
            var toParameter = to.HasValue ?
                new ObjectParameter("To", to) :
                new ObjectParameter("To", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DiscountsReport_Result>("DiscountsReport", fromParameter, toParameter);
        }
    
        public virtual ObjectResult<FindPoduct_Result> FindPoduct(string category, string size, string supplier, string feature, string color, string neckFinish, string weight)
        {
            var categoryParameter = category != null ?
                new ObjectParameter("Category", category) :
                new ObjectParameter("Category", typeof(string));
    
            var sizeParameter = size != null ?
                new ObjectParameter("Size", size) :
                new ObjectParameter("Size", typeof(string));
    
            var supplierParameter = supplier != null ?
                new ObjectParameter("Supplier", supplier) :
                new ObjectParameter("Supplier", typeof(string));
    
            var featureParameter = feature != null ?
                new ObjectParameter("Feature", feature) :
                new ObjectParameter("Feature", typeof(string));
    
            var colorParameter = color != null ?
                new ObjectParameter("Color", color) :
                new ObjectParameter("Color", typeof(string));
    
            var neckFinishParameter = neckFinish != null ?
                new ObjectParameter("NeckFinish", neckFinish) :
                new ObjectParameter("NeckFinish", typeof(string));
    
            var weightParameter = weight != null ?
                new ObjectParameter("Weight", weight) :
                new ObjectParameter("Weight", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<FindPoduct_Result>("FindPoduct", categoryParameter, sizeParameter, supplierParameter, featureParameter, colorParameter, neckFinishParameter, weightParameter);
        }
    
        public virtual ObjectResult<GetCustomer_Result> GetCustomer(Nullable<int> custID)
        {
            var custIDParameter = custID.HasValue ?
                new ObjectParameter("CustID", custID) :
                new ObjectParameter("CustID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetCustomer_Result>("GetCustomer", custIDParameter);
        }
    
        public virtual ObjectResult<string> GetHaulierID()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetHaulierID");
        }
    
        public virtual ObjectResult<Nullable<int>> GetPriceLists(Nullable<int> custID, Nullable<bool> incUnlisted)
        {
            var custIDParameter = custID.HasValue ?
                new ObjectParameter("CustID", custID) :
                new ObjectParameter("CustID", typeof(int));
    
            var incUnlistedParameter = incUnlisted.HasValue ?
                new ObjectParameter("IncUnlisted", incUnlisted) :
                new ObjectParameter("IncUnlisted", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("GetPriceLists", custIDParameter, incUnlistedParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> HasBalanceP(Nullable<int> cust, Nullable<System.DateTime> sDate)
        {
            var custParameter = cust.HasValue ?
                new ObjectParameter("Cust", cust) :
                new ObjectParameter("Cust", typeof(int));
    
            var sDateParameter = sDate.HasValue ?
                new ObjectParameter("SDate", sDate) :
                new ObjectParameter("SDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("HasBalanceP", custParameter, sDateParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> HasBalanceP_Old(Nullable<int> cust, Nullable<System.DateTime> sDate)
        {
            var custParameter = cust.HasValue ?
                new ObjectParameter("Cust", cust) :
                new ObjectParameter("Cust", typeof(int));
    
            var sDateParameter = sDate.HasValue ?
                new ObjectParameter("SDate", sDate) :
                new ObjectParameter("SDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("HasBalanceP_Old", custParameter, sDateParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> HasOrderedP(Nullable<int> cust, Nullable<System.DateTime> sDate)
        {
            var custParameter = cust.HasValue ?
                new ObjectParameter("Cust", cust) :
                new ObjectParameter("Cust", typeof(int));
    
            var sDateParameter = sDate.HasValue ?
                new ObjectParameter("SDate", sDate) :
                new ObjectParameter("SDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("HasOrderedP", custParameter, sDateParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> HasOrderedP_Old(Nullable<int> cust, Nullable<System.DateTime> sDate)
        {
            var custParameter = cust.HasValue ?
                new ObjectParameter("Cust", cust) :
                new ObjectParameter("Cust", typeof(int));
    
            var sDateParameter = sDate.HasValue ?
                new ObjectParameter("SDate", sDate) :
                new ObjectParameter("SDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("HasOrderedP_Old", custParameter, sDateParameter);
        }
    
        public virtual ObjectResult<InvoicesReport_Result> InvoicesReport(Nullable<System.DateTime> from, Nullable<System.DateTime> to)
        {
            var fromParameter = from.HasValue ?
                new ObjectParameter("From", from) :
                new ObjectParameter("From", typeof(System.DateTime));
    
            var toParameter = to.HasValue ?
                new ObjectParameter("To", to) :
                new ObjectParameter("To", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<InvoicesReport_Result>("InvoicesReport", fromParameter, toParameter);
        }
    
        public virtual ObjectResult<OIPerformance_Result> OIPerformance(Nullable<int> year, Nullable<int> month)
        {
            var yearParameter = year.HasValue ?
                new ObjectParameter("Year", year) :
                new ObjectParameter("Year", typeof(int));
    
            var monthParameter = month.HasValue ?
                new ObjectParameter("Month", month) :
                new ObjectParameter("Month", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<OIPerformance_Result>("OIPerformance", yearParameter, monthParameter);
        }
    
        public virtual ObjectResult<OrderHistory_Result> OrderHistory(Nullable<int> customerID, Nullable<System.DateTime> startDate, Nullable<System.DateTime> endDate, Nullable<int> dealNumber, string status)
        {
            var customerIDParameter = customerID.HasValue ?
                new ObjectParameter("CustomerID", customerID) :
                new ObjectParameter("CustomerID", typeof(int));
    
            var startDateParameter = startDate.HasValue ?
                new ObjectParameter("StartDate", startDate) :
                new ObjectParameter("StartDate", typeof(System.DateTime));
    
            var endDateParameter = endDate.HasValue ?
                new ObjectParameter("EndDate", endDate) :
                new ObjectParameter("EndDate", typeof(System.DateTime));
    
            var dealNumberParameter = dealNumber.HasValue ?
                new ObjectParameter("DealNumber", dealNumber) :
                new ObjectParameter("DealNumber", typeof(int));
    
            var statusParameter = status != null ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<OrderHistory_Result>("OrderHistory", customerIDParameter, startDateParameter, endDateParameter, dealNumberParameter, statusParameter);
        }
    
        public virtual ObjectResult<PalletBalance_Result> PalletBalance(Nullable<int> cust, Nullable<System.DateTime> from, Nullable<System.DateTime> to)
        {
            var custParameter = cust.HasValue ?
                new ObjectParameter("Cust", cust) :
                new ObjectParameter("Cust", typeof(int));
    
            var fromParameter = from.HasValue ?
                new ObjectParameter("From", from) :
                new ObjectParameter("From", typeof(System.DateTime));
    
            var toParameter = to.HasValue ?
                new ObjectParameter("To", to) :
                new ObjectParameter("To", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PalletBalance_Result>("PalletBalance", custParameter, fromParameter, toParameter);
        }
    
        public virtual ObjectResult<PalletCredit_Result> PalletCredit(Nullable<int> cust)
        {
            var custParameter = cust.HasValue ?
                new ObjectParameter("Cust", cust) :
                new ObjectParameter("Cust", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PalletCredit_Result>("PalletCredit", custParameter);
        }
    
        public virtual ObjectResult<PalletMovementsReport_Result> PalletMovementsReport(Nullable<System.DateTime> from, Nullable<System.DateTime> to)
        {
            var fromParameter = from.HasValue ?
                new ObjectParameter("From", from) :
                new ObjectParameter("From", typeof(System.DateTime));
    
            var toParameter = to.HasValue ?
                new ObjectParameter("To", to) :
                new ObjectParameter("To", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PalletMovementsReport_Result>("PalletMovementsReport", fromParameter, toParameter);
        }
    
        public virtual ObjectResult<PalletMovementSummary_Result> PalletMovementSummary(Nullable<System.DateTime> from, Nullable<System.DateTime> to)
        {
            var fromParameter = from.HasValue ?
                new ObjectParameter("From", from) :
                new ObjectParameter("From", typeof(System.DateTime));
    
            var toParameter = to.HasValue ?
                new ObjectParameter("To", to) :
                new ObjectParameter("To", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PalletMovementSummary_Result>("PalletMovementSummary", fromParameter, toParameter);
        }
    
        public virtual ObjectResult<PalletTransfer_Result> PalletTransfer(Nullable<int> cust, Nullable<System.DateTime> from, Nullable<System.DateTime> to)
        {
            var custParameter = cust.HasValue ?
                new ObjectParameter("Cust", cust) :
                new ObjectParameter("Cust", typeof(int));
    
            var fromParameter = from.HasValue ?
                new ObjectParameter("From", from) :
                new ObjectParameter("From", typeof(System.DateTime));
    
            var toParameter = to.HasValue ?
                new ObjectParameter("To", to) :
                new ObjectParameter("To", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PalletTransfer_Result>("PalletTransfer", custParameter, fromParameter, toParameter);
        }
    
        public virtual ObjectResult<PalletWriteOffs_Result> PalletWriteOffs(Nullable<System.DateTime> from, Nullable<System.DateTime> to)
        {
            var fromParameter = from.HasValue ?
                new ObjectParameter("From", from) :
                new ObjectParameter("From", typeof(System.DateTime));
    
            var toParameter = to.HasValue ?
                new ObjectParameter("To", to) :
                new ObjectParameter("To", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PalletWriteOffs_Result>("PalletWriteOffs", fromParameter, toParameter);
        }
    
        public virtual ObjectResult<PaymentsReport_Result> PaymentsReport(Nullable<System.DateTime> from, Nullable<System.DateTime> to)
        {
            var fromParameter = from.HasValue ?
                new ObjectParameter("From", from) :
                new ObjectParameter("From", typeof(System.DateTime));
    
            var toParameter = to.HasValue ?
                new ObjectParameter("To", to) :
                new ObjectParameter("To", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PaymentsReport_Result>("PaymentsReport", fromParameter, toParameter);
        }
    
        public virtual int PFn()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PFn");
        }
    
        public virtual ObjectResult<ProduceStatements_Result> ProduceStatements(Nullable<int> custID, Nullable<System.DateTime> startDate, Nullable<System.DateTime> endDate)
        {
            var custIDParameter = custID.HasValue ?
                new ObjectParameter("CustID", custID) :
                new ObjectParameter("CustID", typeof(int));
    
            var startDateParameter = startDate.HasValue ?
                new ObjectParameter("StartDate", startDate) :
                new ObjectParameter("StartDate", typeof(System.DateTime));
    
            var endDateParameter = endDate.HasValue ?
                new ObjectParameter("EndDate", endDate) :
                new ObjectParameter("EndDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ProduceStatements_Result>("ProduceStatements", custIDParameter, startDateParameter, endDateParameter);
        }
    
        public virtual ObjectResult<ProductReport_Result> ProductReport(string productID, Nullable<int> year, Nullable<int> month)
        {
            var productIDParameter = productID != null ?
                new ObjectParameter("ProductID", productID) :
                new ObjectParameter("ProductID", typeof(string));
    
            var yearParameter = year.HasValue ?
                new ObjectParameter("Year", year) :
                new ObjectParameter("Year", typeof(int));
    
            var monthParameter = month.HasValue ?
                new ObjectParameter("Month", month) :
                new ObjectParameter("Month", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ProductReport_Result>("ProductReport", productIDParameter, yearParameter, monthParameter);
        }
    
        public virtual ObjectResult<ProductReport2_Result> ProductReport2(string productID, Nullable<int> year, Nullable<int> month)
        {
            var productIDParameter = productID != null ?
                new ObjectParameter("ProductID", productID) :
                new ObjectParameter("ProductID", typeof(string));
    
            var yearParameter = year.HasValue ?
                new ObjectParameter("Year", year) :
                new ObjectParameter("Year", typeof(int));
    
            var monthParameter = month.HasValue ?
                new ObjectParameter("Month", month) :
                new ObjectParameter("Month", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ProductReport2_Result>("ProductReport2", productIDParameter, yearParameter, monthParameter);
        }
    
        public virtual int ResetOrderDetails(Nullable<int> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ResetOrderDetails", userIDParameter);
        }
    
        public virtual ObjectResult<SalesInvoices_Result> SalesInvoices(Nullable<System.DateTime> from, Nullable<System.DateTime> to)
        {
            var fromParameter = from.HasValue ?
                new ObjectParameter("From", from) :
                new ObjectParameter("From", typeof(System.DateTime));
    
            var toParameter = to.HasValue ?
                new ObjectParameter("To", to) :
                new ObjectParameter("To", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SalesInvoices_Result>("SalesInvoices", fromParameter, toParameter);
        }
    
        public virtual ObjectResult<Statements2_Result> Statements2(Nullable<int> cust, Nullable<System.DateTime> balDate)
        {
            var custParameter = cust.HasValue ?
                new ObjectParameter("Cust", cust) :
                new ObjectParameter("Cust", typeof(int));
    
            var balDateParameter = balDate.HasValue ?
                new ObjectParameter("BalDate", balDate) :
                new ObjectParameter("BalDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Statements2_Result>("Statements2", custParameter, balDateParameter);
        }
    
        public virtual ObjectResult<Statements3_Result> Statements3(Nullable<int> cust, Nullable<System.DateTime> balDate)
        {
            var custParameter = cust.HasValue ?
                new ObjectParameter("Cust", cust) :
                new ObjectParameter("Cust", typeof(int));
    
            var balDateParameter = balDate.HasValue ?
                new ObjectParameter("BalDate", balDate) :
                new ObjectParameter("BalDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Statements3_Result>("Statements3", custParameter, balDateParameter);
        }
    
        public virtual ObjectResult<Statements3_old_Result> Statements3_old(Nullable<int> cust, Nullable<System.DateTime> balDate)
        {
            var custParameter = cust.HasValue ?
                new ObjectParameter("Cust", cust) :
                new ObjectParameter("Cust", typeof(int));
    
            var balDateParameter = balDate.HasValue ?
                new ObjectParameter("BalDate", balDate) :
                new ObjectParameter("BalDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Statements3_old_Result>("Statements3_old", custParameter, balDateParameter);
        }
    
        public virtual ObjectResult<StatementsFrom_Result> StatementsFrom(Nullable<int> cust, Nullable<System.DateTime> balDate, Nullable<System.DateTime> fromDate)
        {
            var custParameter = cust.HasValue ?
                new ObjectParameter("Cust", cust) :
                new ObjectParameter("Cust", typeof(int));
    
            var balDateParameter = balDate.HasValue ?
                new ObjectParameter("BalDate", balDate) :
                new ObjectParameter("BalDate", typeof(System.DateTime));
    
            var fromDateParameter = fromDate.HasValue ?
                new ObjectParameter("FromDate", fromDate) :
                new ObjectParameter("FromDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<StatementsFrom_Result>("StatementsFrom", custParameter, balDateParameter, fromDateParameter);
        }
    
        public virtual ObjectResult<StockLevel_Result> StockLevel(string supplier, Nullable<System.DateTime> stockDate)
        {
            var supplierParameter = supplier != null ?
                new ObjectParameter("Supplier", supplier) :
                new ObjectParameter("Supplier", typeof(string));
    
            var stockDateParameter = stockDate.HasValue ?
                new ObjectParameter("StockDate", stockDate) :
                new ObjectParameter("StockDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<StockLevel_Result>("StockLevel", supplierParameter, stockDateParameter);
        }
    
        public virtual ObjectResult<StockSheet_Result> StockSheet(string prod)
        {
            var prodParameter = prod != null ?
                new ObjectParameter("Prod", prod) :
                new ObjectParameter("Prod", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<StockSheet_Result>("StockSheet", prodParameter);
        }
    
        public virtual int SumByStatementMonth()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SumByStatementMonth");
        }
    
        public virtual ObjectResult<SupplierReport_Result> SupplierReport(string supplierID, Nullable<int> year, Nullable<int> month)
        {
            var supplierIDParameter = supplierID != null ?
                new ObjectParameter("SupplierID", supplierID) :
                new ObjectParameter("SupplierID", typeof(string));
    
            var yearParameter = year.HasValue ?
                new ObjectParameter("Year", year) :
                new ObjectParameter("Year", typeof(int));
    
            var monthParameter = month.HasValue ?
                new ObjectParameter("Month", month) :
                new ObjectParameter("Month", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SupplierReport_Result>("SupplierReport", supplierIDParameter, yearParameter, monthParameter);
        }
    
        public virtual ObjectResult<VATOutput_Result> VATOutput(Nullable<int> year, Nullable<int> month, Nullable<decimal> amntAdj, Nullable<decimal> vATAdj)
        {
            var yearParameter = year.HasValue ?
                new ObjectParameter("Year", year) :
                new ObjectParameter("Year", typeof(int));
    
            var monthParameter = month.HasValue ?
                new ObjectParameter("Month", month) :
                new ObjectParameter("Month", typeof(int));
    
            var amntAdjParameter = amntAdj.HasValue ?
                new ObjectParameter("AmntAdj", amntAdj) :
                new ObjectParameter("AmntAdj", typeof(decimal));
    
            var vATAdjParameter = vATAdj.HasValue ?
                new ObjectParameter("VATAdj", vATAdj) :
                new ObjectParameter("VATAdj", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VATOutput_Result>("VATOutput", yearParameter, monthParameter, amntAdjParameter, vATAdjParameter);
        }
    }
}
