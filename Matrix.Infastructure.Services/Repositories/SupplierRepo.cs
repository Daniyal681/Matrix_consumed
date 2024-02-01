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
    public class SupplierRepo : ISupplierRepo
    {
        private MatrixContext _context;
        public SupplierRepo(MatrixContext context)
        {
            _context = context;
        }
        public void AddSupplier(SupplierDTO req)
        {
            try
            {
                var isExist = _context.Suppliers.Where(x => x.SupplierName == req.SupplierName).FirstOrDefault();
                if (isExist != null)
                    throw new Exception("Supplier with the same name already exist");

                tblSuppliers tblReq = new tblSuppliers
                {
                    SupplierName = req.SupplierName
                };
                _context.Suppliers.Add(tblReq);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> EditSupplier(EditSuppliers req)
        {
            try
            {
                var isExist = await _context.Suppliers.Where(x => x.SupplierID == req.SuppliersID).FirstOrDefaultAsync();
                if (isExist != null)
                {
                    isExist.IsActive = req.IsActive ? EStatus.Active : EStatus.Deactive;
                    isExist.SupplierName = req.SuppliersName;
                    await _context.SaveChangesAsync();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<GetSuppliers>> GetSupplier()
        {
            try
            {
                return await _context.Suppliers.Where(s => s.IsActive == EStatus.Active || s.IsActive == EStatus.Deactive)
                       .Select(s => new GetSuppliers
                       { SupplierID = s.SupplierID, SupplierName = s.SupplierName, IsActive = s.IsActive }
                       ).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<EditSuppliers> Getsupplier(int SuppliersID)
        {
            try
            {
                var isExist = await _context.Suppliers.Where(s => s.IsActive == EStatus.Active).FirstOrDefaultAsync(b => b.SupplierID == SuppliersID);

                if (isExist != null)
                {
                    var SupplierDTO = new EditSuppliers
                    {
                        SuppliersID = isExist.SupplierID,
                        SuppliersName = isExist.SupplierName,
                        IsActive = (int)isExist.IsActive == 2 ? true : false
                    };
                    return SupplierDTO;
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
