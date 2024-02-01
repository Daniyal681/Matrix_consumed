using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Core.Application.DTOs
{
    public class SupplierDTO
    {
        public string SupplierName { get; set; }
    }

    public class GetSuppliers
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public EStatus IsActive { get; set; }

    }

    public class EditSuppliers
    {
        public int SuppliersID { get; set; }
        public string SuppliersName { get; set; }
        public bool IsActive { get; set; }
    }
}
