using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Core.Application.DTOs
{
    public class MenuListDTO
    {
        public int MenuListId { get; set; }
        public string? MenuListTitle { get; set; }
        public string? MenuListDescription { get; set; }
        public int? MenuListParentId { get; set; }
        public bool? MenuListHasChildren { get; set; }
        public int? MenuListSortOrder { get; set; }
        public string? MenuListNavigationUrl { get; set; }
        public string? MenuListIconClass { get; set; }
        public EStatus IsActive { get; set; }

    }
}
