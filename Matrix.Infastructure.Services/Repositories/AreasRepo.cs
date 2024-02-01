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
    public class AreasRepo :IAreasRepo
    {
        private MatrixContext _context;
        public AreasRepo(MatrixContext context)
        {
            _context = context;
        }

        public async Task<GetAreas> GetArea(int AreasID)
        {
            try
            {
                var isExist = await _context.Areas.FirstOrDefaultAsync(b => b.AreaID == AreasID);

                if (isExist != null)
                {
                    var AreasDTO = new GetAreas
                    {
                        AreaID = isExist.AreaID,
                        AreaCode = isExist.AreaCode,
                        AreaName = isExist.AreaCode + " - " + isExist.AreaName,
                        IsActive = (int)isExist.IsActive == 2 ? true : false
                    };
                    return AreasDTO;
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
