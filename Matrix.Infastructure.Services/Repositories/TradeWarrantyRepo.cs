using Matrix.Core.Application.DTOs;
using Matrix.Core.Application.Interfaces;
using Matrix.Core.Domain.Entities;
using Matrix.Infastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Matrix.Infastructure.Services.Repositories
{
    public class TradeWarrantyRepo : ITradeWarrantyRepo
    {
        private MatrixContext _context;
        public TradeWarrantyRepo(MatrixContext context)
        {
            _context = context;
        }

       
        public async Task<bool> EditTradeWarranty(EditTradeWarranty req)
        {
            try
            {
                var isExist = await _context.TradeWarranty.Where(x => x.RecID == req.RecID).FirstOrDefaultAsync();
                if (isExist != null)
                {
                    //isExist.IsActive = req.IsActive ? EStatus.Active : EStatus.Deactive;
                    isExist.TransactionDate = DateTime.UtcNow;
                    isExist.ModelID =req.ModelID;
                    isExist.WarrantyPeriod= req.WarrantyPeriod;
                    isExist.WarrantyFrom = req.WarrantyFrom;
                    isExist.WarrantyUpto = req.WarrantyUpto;
                    isExist.CashBack= req.CashBack;
                    await _context.SaveChangesAsync();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void GenerateTradeWarranty(TradeWarrantyRequest req)
        {
            try
            {
                tblTradeWarranty tblreq = new tblTradeWarranty
                {
                    TransactionDate = req.TransactionDate,
                    ModelID = req.ModelID,
                    WarrantyPeriod = req.WarrantyPeriod,
                    WarrantyFrom = req.WarrantyFrom,
                    WarrantyUpto = req.WarrantyUpto,
                    CashBack = req.CashBack,
                    Remarks = req.Remarks,
                    TradeWarrantyDetails = req.LineItems.Select(s => new tblTradeWarrantyDetails
                    {
                        WareHouseID = s.WareHouseID,
                        Amount = (s.Rate * s.QTY),
                        ModelID = s.ModelID,
                        Rate = s.Rate,
                        QTY = s.QTY
                    }).ToList()
                };
                _context.TradeWarranty.Add(tblreq);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<GetTradeWarrantyRequest>> GetTradeWarranty()
        {
            try
            {
                return await _context.TradeWarranty
                    .Where(x => x.IsActive == EStatus.Active)
                    .Select(x => new GetTradeWarrantyRequest
                    {
                        RecID = x.RecID,
                        TransactionNumber = x.TransactionNo,
                        TransactionDate = x.TransactionDate.ToString("dd/MM/yyyy"),
                        ModelID = x.ModelID,
                        WarrantyPeriod = x.WarrantyPeriod.ToString("dd/MM/yyyy"),
                        WarrantyFrom = x.WarrantyFrom.ToString("dd/MM/yyyy"),
                        WarrantyUpto = x.WarrantyUpto.ToString("dd/MM/yyyy"),
                        CashBack = x.CashBack
                    }).ToListAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<EditTradeWarranty> Gettradewarranty(int RecID)
        {
            try
            {
                var isExist = await _context.TradeWarranty.FirstOrDefaultAsync(b => b.RecID == RecID);

                if (isExist != null)
                {
                    var tradewarranty = new EditTradeWarranty
                    {
                        TransactionDate = isExist.TransactionDate,
                        ModelID = isExist.ModelID,
                        WarrantyPeriod = isExist.WarrantyPeriod,
                        WarrantyFrom = isExist.WarrantyFrom,
                        WarrantyUpto = isExist.WarrantyUpto,
                        CashBack = isExist.CashBack,
                        //IsActive = (int)isExist.IsActive == 2 ? true : false
                    };
                    return tradewarranty;
                }
                else
                {
                    throw new Exception("Null Data!");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
