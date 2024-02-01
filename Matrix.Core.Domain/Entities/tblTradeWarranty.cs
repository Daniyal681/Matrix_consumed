using Matrix.Core.Application.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Core.Domain.Entities
{
    public class tblTradeWarranty
    {
        [Key]
        public int RecID { get; set; }
        public string TransactionNo { get { return string.Concat("War-", RecID.ToString().PadLeft(8, '0')); } }
        public DateTime TransactionDate { get; set; }
        public int ModelID { get; set; }
        public DateTime WarrantyPeriod { get; set; }
        public DateTime WarrantyFrom { get; set; }
        public DateTime WarrantyUpto { get; set; }
        public double CashBack { get; set; }
        public string? Remarks { get; set; }
        public EStatus IsActive { get; set; } = EStatus.Active;

        public virtual List<tblTradeWarrantyDetails> TradeWarrantyDetails { get; set; }

        [ForeignKey("ModelID")]
        public virtual tblModels ModelDetails { get; set; }
    }
}
