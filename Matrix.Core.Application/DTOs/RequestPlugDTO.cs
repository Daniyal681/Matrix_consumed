using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Core.Application.DTOs
{
    public class JSONResultResp
    {
        public bool hasError { get; set; } = false;
        public string error { get; set; }
        public dynamic response { get; set; }
    }
}
