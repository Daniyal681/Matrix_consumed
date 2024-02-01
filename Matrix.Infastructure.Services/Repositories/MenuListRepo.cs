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
    public class MenuListRepo : IMenuListRepo
    {
        private MatrixContext _context;
        public MenuListRepo(MatrixContext context)
        {
            _context = context;   
        }
        public async Task<List<MenuListDTO>> GetMenuLists()
        {
            try
            {
                return await _context.MenuList
                    .Where(s => s.IsActive == EStatus.Active || s.IsActive == EStatus.Deactive)
                    .Select(s => new MenuListDTO { MenuListId = s.MenuListId, MenuListTitle = s.MenuListTitle, MenuListDescription = s.MenuListDescription,MenuListParentId = s.MenuListParentId , MenuListHasChildren = s.MenuListHasChildren, MenuListSortOrder = s.MenuListSortOrder , MenuListNavigationUrl = s.MenuListNavigationUrl , MenuListIconClass = s.MenuListIconClass , IsActive = s.IsActive }).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
