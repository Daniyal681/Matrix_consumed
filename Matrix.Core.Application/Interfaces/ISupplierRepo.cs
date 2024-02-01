using Matrix.Core.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Core.Application.Interfaces
{
    public interface ISupplierRepo
    {
        void AddSupplier(SupplierDTO req);
        Task<List<GetSuppliers>> GetSupplier();
        Task<bool>EditSupplier(EditSuppliers req);
        Task<EditSuppliers> Getsupplier(int SuppliersID);

    }
}
