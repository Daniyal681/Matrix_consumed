using Matrix.Core.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Core.Application.Interfaces
{
    public interface IBankRepo
    {
        void AddBank(BankDTO req);
        Task<List<GetBanks>> GetBank();
        Task<bool> EditBank(EditBanks req);
        Task<EditBanks> GetBank(int BankID);
    }
}
