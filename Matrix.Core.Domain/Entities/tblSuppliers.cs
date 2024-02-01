using Matrix.Core.Application.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Core.Domain.Entities
{
    public class tblSuppliers
    {
        [Key]
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public EStatus IsActive { get; set; } = EStatus.Active;

        public virtual List<tblLocalPurchase> LocalPurchase { get; set; }
    }
}
