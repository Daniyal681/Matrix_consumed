using Matrix.Core.Application.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Core.Domain.Entities
{
    public class tblBank
    {
        [Key]
        public int BankID { get; set; }
        public string BankName { get; set; }
       public EStatus IsActive { get; set; } = EStatus.Active;
    }
}
