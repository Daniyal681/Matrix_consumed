using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Matrix.Core.Domain.Entities
{
    public class tblWareHouseInHoldProducts
    {
        [Key]
        public int RecID { get; set; }
        public int ModelID { get; set; }
        public int WareHouseID { get; set; }
        public int QTY { get; set; }

        [ForeignKey("WareHouseID")]
        public virtual tblWareHouse WareHouse { get; set; }

        [ForeignKey("ModelID")]
        public virtual tblModels Model { get; set; }
    }
}
