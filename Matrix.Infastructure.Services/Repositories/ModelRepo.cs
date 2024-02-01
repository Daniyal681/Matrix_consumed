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
    public class ModelRepo : IModelRepo
    {
        private MatrixContext _context;
        public ModelRepo(MatrixContext context)
        {
            _context = context;
        }
        public void AddModel(ModelDTO req)
        {
            try
            {
                var isExist = _context.Models.Where(x => x.ModelName == req.ModelName).FirstOrDefault();
                if (isExist != null)
                    throw new Exception("Model with the same name already exist");

                tblModels tblReq = new tblModels
                {
                    ModelName = req.ModelName
                };
                _context.Models.Add(tblReq);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> EditModel(EditModel req)
        {
            try
            {
                var isExist = await _context.Models.Where(x => x.ModelID == req.ModelID).FirstOrDefaultAsync();
                if (isExist != null)
                {
                    isExist.IsActive = req.IsActive ? EStatus.Active : EStatus.Deactive;
                    isExist.ModelName = req.ModelName;
                    await _context.SaveChangesAsync();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<GetModels>> GetModel()
        {
            try
            {
                return await _context.Models
                    .Where(s => s.IsActive == EStatus.Active || s.IsActive == EStatus.Deactive)
                    .Select(
                        s => new GetModels
                        { 
                            ModelID = s.ModelID, 
                            ModelName = s.ModelName, 
                            IsActive = s.IsActive == EStatus.Active ? true : false
                        }
                    ).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<EditModel> GetModel(int ModelID)
        {
            try
            {
                var isExist = await _context.Models.Where(s => s.IsActive == EStatus.Active).FirstOrDefaultAsync(b => b.ModelID == ModelID);

                if (isExist != null)
                {
                    var ModelDTO = new EditModel
                    {
                        ModelID = isExist.ModelID,
                        ModelName = isExist.ModelName,
                        IsActive = (int)isExist.IsActive == 2 ? true : false
                    };
                    return ModelDTO;
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
