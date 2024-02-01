using Matrix.Core.Application.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Core.Domain.Entities
{
    public class tblMenuList
    {
        [Key]
        public int MenuListId { get; set; }
        public string MenuListTitle { get; set; }
        public string? MenuListDescription { get; set; }
        public int MenuListParentId { get; set; } = 0;
        public bool MenuListHasChildren { get; set; } = false;
        public int? MenuListSortOrder { get; set; }
        public string MenuListNavigationUrl { get; set; }
        public string? MenuListIconClass { get; set; }
        public EStatus IsActive { get; set; } = EStatus.Active;
    }
}
