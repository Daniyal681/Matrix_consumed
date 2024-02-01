using Matrix.Core.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Core.Application.Interfaces
{
    public interface IWareHouseRepo
    {
        void AddWareHouse(WareHouseDTO req);
        Task<List<GetWareHouse>> GetWareHouse();
        Task<EditWarehouse> GetWareHouse(int WarehouseID);

        Task<bool>EditWarehouse(EditWarehouse req);
    }
}
