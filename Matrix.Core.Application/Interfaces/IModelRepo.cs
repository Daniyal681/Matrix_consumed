using Matrix.Core.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Core.Application.Interfaces
{
    public interface IModelRepo
    {
        void AddModel(ModelDTO req);
        Task<List<GetModels>> GetModel();
        Task<bool> EditModel(EditModel req);
        Task<EditModel> GetModel(int ModelID);
    }
}
