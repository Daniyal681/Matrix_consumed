using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Matrix.Core.Domain.Entities
{
    public class tblLocalPurchaseDetails
    {
        [Key]
        public int RecID { get; set; }
        public int LocalPurchaseID { get; set; }
        public int ModelID { get; set; }
        public int QTY { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public int WareHouseID { get; set; }
        
        [ForeignKey("LocalPurchaseID")]
        public virtual tblLocalPurchase LocalPurchase { get; set; }
        
        [ForeignKey("WareHouseID")]
        public virtual tblWareHouse WareHouse { get; set; }
        
        [ForeignKey("ModelID")]
        public virtual tblModels DeviceModel { get; set; }
    }
}
