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
    public class tblWareHouse
    {
        [Key]
        public int WareHouseID { get; set; }
        public string WareHouseName { get; set; }
        public EStatus IsActive { get; set; } = EStatus.Active;

        public virtual List<tblLocalPurchaseDetails> PurchaseDetails { get; set; }
        public virtual List<tblWareHouseInHoldProducts> WareHouseInHoldProducts { get; set; }
    }
}
