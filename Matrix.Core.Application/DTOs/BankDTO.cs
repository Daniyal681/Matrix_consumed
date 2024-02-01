using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Core.Application.DTOs
{
    public class BankDTO
    {
        public string BankName { get; set; }
    }   

    public class GetBanks
    {
        public int BankID { get; set; }
        public string BankName { get; set; }
        public EStatus IsActive { get; set; }
    }

    public class EditBanks
    {
        public int BankID { get; set; }
        public string BankName { get; set; }
        public bool IsActive { get; set; }
    }

    public class GetBank
    {
        public string BankName { get; set; }
    }
}
