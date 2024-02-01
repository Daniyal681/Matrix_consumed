using Matrix.Core.Application.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Core.Domain.Entities
{
    public class tblUser
    {
        [Key]
        public int UserId { get; set; }
        public string UserLoginID { get; set; }
        public string UserPassword { get; set; }
        public EStatus IsActive { get; set; } = EStatus.Active;
    }
}
