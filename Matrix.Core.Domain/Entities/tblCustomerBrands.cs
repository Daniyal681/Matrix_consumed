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
    public class tblCustomerBrands
    {
        [Key]
        public int RecID { get; set; }
        public int CustomerID { get; set; }
        public int BrandID { get; set; }

        public EStatus IsActive { get; set; } = EStatus.Active;

        [ForeignKey("CustomerID")]
        public virtual tblCustomer Customer { get; set; }

        [ForeignKey("BrandID")]
        public virtual tblBrands Brands { get; set; }
    }
}
