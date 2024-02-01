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
    public class WareHouseRepo : IWareHouseRepo
    {
        private MatrixContext _context;
        public WareHouseRepo(MatrixContext context)
        {
            _context = context;
        }

        public void AddWareHouse(WareHouseDTO req)
        {
            try
            {
                var isExist = _context.WareHouses.Where(x=>x.WareHouseName == req.WareHouseName).FirstOrDefault();
                if (isExist != null)
                    throw new Exception("Warehouse with the same name already exist");

                tblWareHouse tblReq = new tblWareHouse
                {
                  WareHouseName = req.WareHouseName
                };
                _context.WareHouses.Add(tblReq);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> EditWarehouse(EditWarehouse req)
        {
            try
            {
                var isExist = await _context.WareHouses.Where(x => x.WareHouseID == req.WarehouseID).FirstOrDefaultAsync();
                if (isExist != null)
                {

                    if (req.IsActive)
                    {
                        isExist.IsActive = EStatus.Active;
                    }
                    else
                    {
                        isExist.IsActive = EStatus.Deactive;
                    }
                    isExist.WareHouseName = req.WarehouseName;
                }
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<GetWareHouse>> GetWareHouse()
        {

            try
            {
                return await _context.WareHouses.Where(s => s.IsActive == EStatus.Active || s.IsActive == EStatus.Deactive)
                        .Select(s => new GetWareHouse
                        { WareHouseID = s.WareHouseID, WareHouseName = s.WareHouseName,  IsActive = s.IsActive }
                        ).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<EditWarehouse> GetWareHouse(int WarehouseID)
        {
            try
            {
                var isExist = await _context.WareHouses.Where(s => s.IsActive == EStatus.Active).FirstOrDefaultAsync(b => b.WareHouseID == WarehouseID);

                if (isExist != null)
                {
                    var WarehouseDTO = new EditWarehouse
                    {
                        WarehouseID = isExist.WareHouseID,
                        WarehouseName = isExist.WareHouseName,
                        IsActive = (int)isExist.IsActive == 2 ? true : false
                    };
                    return WarehouseDTO;
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
