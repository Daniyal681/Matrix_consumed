using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Core.Application.DTOs
{
    public class WareHouseDTO
    {
        public string WareHouseName { get; set; }
    }
    public class GetWareHouse
    {
        public int WareHouseID { get; set; }
        public string WareHouseName { get; set; }
        public EStatus IsActive { get; set; }

    }

    public class EditWarehouse
    {
        public int WarehouseID { get; set; }
        public string WarehouseName { get; set; }
        public bool IsActive { get; set; }
    }
}
