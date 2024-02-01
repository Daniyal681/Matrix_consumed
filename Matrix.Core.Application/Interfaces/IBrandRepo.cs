using Matrix.Core.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Core.Application.Interfaces
{
    public interface IBrandRepo
    {
        Task<List<GetBrandsDTO>> GetBrands();
    }
}
