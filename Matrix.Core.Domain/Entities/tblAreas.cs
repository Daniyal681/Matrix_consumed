using Matrix.Core.Application.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Core.Domain.Entities
{
    public class tblAreas
    {
        [Key]
        public int AreaID { get; set; }
        public string AreaCode { get; set; }
        public string AreaName { get; set; }
        public int OrderBy { get; set; }

        public EStatus IsActive { get; set; } = EStatus.Active;
        public virtual List<tblCustomer> Customers { get; set; }
    }
}
