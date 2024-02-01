using Matrix.Core.Application.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Core.Domain.Entities
{
    public class tblBrands
    {
        [Key]
        public int BrandID { get; set; }
        public string BrandName { get; set; }
        public EStatus IsActive { get; set; } = EStatus.Active;
        public virtual List<tblCustomerBrands> CustomerBrands { get; set; }

    }
}
