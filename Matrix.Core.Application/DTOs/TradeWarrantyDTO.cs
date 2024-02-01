using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Core.Application.DTOs
{
    public class TradeWarrantyRequest
    {
        public int RecID { get; set; }
        public string TransactionNumber { get; set; }
        public DateTime TransactionDate { get; set; }
        public int ModelID { get; set; }
        public DateTime WarrantyPeriod { get; set; }
        public DateTime WarrantyFrom { get; set; }
        public DateTime WarrantyUpto { get; set; }
        public double CashBack {  get; set; }
        public string? Remarks { get; set; } = string.Empty;
        public List<TradeWarrantyLineItemRequest> LineItems { get; set; }
    }
    public class TradeWarrantyLineItemRequest
    {
        public int ModelID { get; set; }
        public int QTY { get; set; }
        public decimal Rate { get; set; }
        public int WareHouseID { get; set; }
    }
    public class GetTradeWarrantyRequest
    {
        public int RecID { get; set; }
        public string TransactionNumber { get; set; }
        public string TransactionDate { get; set; }
        public int ModelID { get; set; }
        public string WarrantyPeriod { get; set; }
        public string WarrantyFrom { get; set; }
        public string WarrantyUpto { get; set; }
        public double CashBack { get; set; }
    }
    public class EditTradeWarranty
    {
        public int RecID { get; set; }
        public string TransactionNumber { get; set; }
        public DateTime TransactionDate { get; set; }
        public int ModelID { get; set; }
        public DateTime WarrantyPeriod { get; set; }
        public DateTime WarrantyFrom { get; set; }
        public DateTime WarrantyUpto { get; set; }
        public double CashBack { get; set; }
    }
}
