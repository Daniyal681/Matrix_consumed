using Matrix.Core.Application.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Core.Domain.Entities
{
    public class tblModels
    {
        [Key]
        public int ModelID { get; set; }
        public string ModelName { get; set; }
        public EStatus IsActive { get; set; } = EStatus.Active;
        public virtual List<tblLocalPurchaseDetails> PurchaseDetails { get; set; }
        public virtual List<tblWareHouseInHoldProducts> WareHouseInHoldProducts { get; set; }
    }
}
