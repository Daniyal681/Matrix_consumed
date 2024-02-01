using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Core.Application.DTOs
{
    public enum EStatus
    {
        [Description("Default")]
        Default  = 1,
        [Description("Active")]
        Active = 2,
        [Description("Removed")]
        Deactive = 3,
        [Description("Deleted")]
        Deleted = 4
    }
}
