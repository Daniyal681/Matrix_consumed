using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Core.Application.DTOs
{
    public class LocalPurchaseRequest
    {
        public int RecID { get; set; }
        public DateTime TransactionDate { get; set; }
        public int SupplierID { get; set; }
        public string SupplierInvoice { get; set; }
        public string SupplierName { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime PaymentDueDate { get; set; }
        public decimal Other { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public string? Remarks { get; set; } = string.Empty;
        public EStatus IsActive { get; set; }

        public List<LocalPurchaseLineItemRequest> LineItems { get; set; }
    }
    public class LocalPurchaseLineItemRequest
    {
        public int ModelID { get; set; }
        public int QTY { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public int WareHouseID { get; set; }
    }

    public class GetLocalPurchase
    {
        public int RecID { get; set; }
        public string TransactionNo { get; set; }
        public string TransactionDate { get; set; }
        public int SupplierID { get; set;}
        public string SupplierName { get; set; }
        public string SupplierInvoiceNo { get; set;}
        public string InvoiceDate { get; set; }
        public string PaymentDueDate { get; set; }
        public decimal Other { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }


    }
    public class EditLocalPurchase
    {
        public int RecID { get; set; }
        public string TransactionNo { get; set; }
        public DateTime TransactionDate { get; set; }
        public int SupplierID { get; set;}
        public string SupplierName { get; set; }
        public string SupplierInvoiceNo { get; set;}
        public DateTime InvoiceDate { get; set; }
        public DateTime PaymentDueDate { get; set; }
        public string Remarks { get; set; }
        public decimal Other { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public List<LocalPurchaseLineItemRequest> LineItems { get; set; }
    }
}
