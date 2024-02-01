using Matrix.Core.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Core.Application.Interfaces
{
    public interface ITradeWarrantyRepo
    {
        void GenerateTradeWarranty(TradeWarrantyRequest req);
        Task<List<GetTradeWarrantyRequest>> GetTradeWarranty();
        Task<bool> EditTradeWarranty(EditTradeWarranty req);
        Task<EditTradeWarranty> Gettradewarranty(int RecID);


    }
}
