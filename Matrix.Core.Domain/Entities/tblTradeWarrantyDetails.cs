using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Core.Domain.Entities
{
    public class tblTradeWarrantyDetails
    {
        [Key]
        public int RecID { get; set; }
        public int TradeWarrantyID { get; set; }
        public int ModelID { get; set; }
        public int QTY { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public int WareHouseID { get; set; }

        [ForeignKey("TradeWarrantyID")]
        public virtual tblLocalPurchase LocalPurchase { get; set; }

        [ForeignKey("WareHouseID")]
        public virtual tblWareHouse WareHouse { get; set; }

        [ForeignKey("ModelID")]
        public virtual tblModels DeviceModel { get; set; }
    }
}
