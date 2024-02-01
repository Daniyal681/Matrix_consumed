using Matrix.Core.Application.DTOs;
using Matrix.Core.Application.Interfaces;
using Matrix.Core.Domain.Entities;
using Matrix.Infastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Infastructure.Services.Repositories
{
    public class BankRepo : IBankRepo
    {
        private MatrixContext _context;
        public BankRepo(MatrixContext context)
        {
            _context = context;
        }

        public void AddBank(BankDTO req)
        {
            try
            {
                var isExist = _context.Banks.Where(x => x.BankName == req.BankName).FirstOrDefault();
                if (isExist != null)
                    throw new Exception("Bank with the same name already exist");

                tblBank tblReq = new tblBank
                {
                    BankName = req.BankName
                };
                _context.Banks.Add(tblReq);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> EditBank(EditBanks req)
        {
            try
            {
                var isExist = await _context.Banks.Where(x => x.BankID == req.BankID).FirstOrDefaultAsync();
                if (isExist != null)
                {
                    isExist.IsActive = req.IsActive ? EStatus.Active : EStatus.Deactive;
                    isExist.BankName = req.BankName;
                    await _context.SaveChangesAsync();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //try
            //{
            //    var existingBank = await _context.Banks
            //        .Where(x => x.BankID == req.BankID)
            //        .FirstOrDefaultAsync();

            //    if (existingBank != null)
            //    {
            //        if (req.IsActive.HasValue)
            //        {
            //            if (req.IsActive.Value == (int)EStatus.Deactive)
            //            {
            //                existingBank.IsActive = EStatus.Deactive;
            //            }

            //        }
            //        else
            //        {
            //            existingBank.BankName = req.BankName;
            //            await _context.SaveChangesAsync();
            //        }


            //    }

            //return true;
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}

        }

        public async Task<List<GetBanks>> GetBank()
        {
            try
            {
                return await _context.Banks
                    .Where(s => s.IsActive == EStatus.Active || s.IsActive == EStatus.Deactive)
                    .Select(s => new GetBanks { BankID = s.BankID, BankName = s.BankName, IsActive = s.IsActive }).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<EditBanks> GetBank(int BankID)
        {
            try
            {
                var isExist = await _context.Banks.FirstOrDefaultAsync(b => b.BankID == BankID);

                if (isExist != null)
                {
                    var BankDTO = new EditBanks
                    {
                        BankID = isExist.BankID,
                        BankName = isExist.BankName,
                        IsActive = (int)isExist.IsActive == 2 ? true : false
                    };
                    return BankDTO;
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
