using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Core.Application.DTOs
{
    public class ModelDTO
    {
        public string ModelName { get; set; }
    }

    public class GetModels
    {
        public int ModelID { get; set; }
        public string ModelName { get; set; }
        public bool IsActive { get; set; }
    }

    public class EditModel
    {
        public int ModelID { get; set; }
        public string ModelName { get; set; }
        public bool IsActive { get; set; }
    }

    public class GetModel
    {
        public int ModelID { get; set; }
        public string ModelName { get; set; }
        public bool IsActive { get; set; }

    }
}
