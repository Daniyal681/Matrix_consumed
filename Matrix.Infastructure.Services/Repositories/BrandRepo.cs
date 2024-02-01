using Matrix.Core.Application.DTOs;
using Matrix.Core.Application.Interfaces;
using Matrix.Infastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Infastructure.Services.Repositories
{
    public class BrandRepo : IBrandRepo
    {
        private MatrixContext _context;
        public BrandRepo(MatrixContext context)
        {
            _context = context;
        }

        public async Task<List<GetBrandsDTO>> GetBrands()
        {
            try
            {
                return await _context.Brands
                    .Where(s => s.IsActive == EStatus.Active || s.IsActive == EStatus.Deactive)
                    .Select(s => new GetBrandsDTO {BrandID  = s.BrandID, BrandName = s.BrandName}).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
