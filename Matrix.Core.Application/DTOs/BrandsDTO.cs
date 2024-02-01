
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Core.Application.DTOs
{
    public class BrandsDTO
    {
        public int BrandID { get; set; }
        public string BrandName { get; set; }
    }
    public class GetBrandsDTO
    {
        public int BrandID { get; set; }
        public string BrandName { get; set; }

        public bool IsActive { get; set; }


    }
}
