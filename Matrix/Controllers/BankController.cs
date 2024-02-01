using Matrix.Core.Application;
using Matrix.Core.Application.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Matrix.Controllers
{
    public class BankController : Controller
    {
        private IRepositoryWrapper _repoWrapper;

        JSONResultResp resp = new JSONResultResp();
        public BankController(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return PartialView("_Add");
        }

        [HttpPost]
        public async Task<JsonResult> Add(BankDTO req)
        {
           
            try
            {
                if (req == null)
                    throw new Exception("Kindly enter bank name");
                else
                {
                    _repoWrapper.BankRepo.AddBank(req);
                }
            }
            catch (Exception ex)
            {
                resp.hasError = true;
                resp.error = ex.Message;
            }

            return Json(resp);
        }

        [HttpPost]
        public async Task<JsonResult> GetBanks()
        {
            try
            {
                int pageSize = 0;
                var draw = Request.Form["draw"].FirstOrDefault();
                var start = Request.Form["start"].FirstOrDefault();
                var length = Request.Form["length"].FirstOrDefault();
                var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
                var sortColumnDir = Request.Form["order[0][dir]"].FirstOrDefault();
                var searchValue = Request.Form["search[value]"].FirstOrDefault();
                pageSize = !string.IsNullOrEmpty(length) ? Convert.ToInt32(length) : 0;
                int skip = !string.IsNullOrEmpty(start) ? Convert.ToInt32(start) : 0;

                List<GetBanks> banks = await _repoWrapper.BankRepo.GetBank();

                if (!string.IsNullOrEmpty(sortColumn) && !string.IsNullOrEmpty(sortColumnDir))
                {
                    // Apply sorting based on the selected column and direction
                    if (sortColumnDir.ToLower() == "asc")
                    {
                        banks = banks.OrderBy(p => p.BankID).ToList();
                    }
                    else
                    {
                        banks = banks.OrderByDescending(p => p.BankID).ToList();
                    }
                }

                int totalRecord = banks.Count();
                if (pageSize >= 0)
                {
                    banks = banks.Skip(skip).Take(pageSize).ToList();
                }
                if (!string.IsNullOrEmpty(searchValue))
                {
                    if (searchValue.ToLower().Contains("rem"))
                        banks = banks.Where(x => x.IsActive == EStatus.Deactive).ToList();
                    else if (searchValue.ToLower().Contains("act"))
                        banks = banks.Where(x => x.IsActive == EStatus.Active).ToList();
                    else
                    {
                        banks = banks.Where(x => 
                            x.BankID.ToString().Contains(searchValue.ToLower()) ||
                            x.BankName.ToLower().Contains(searchValue.ToLower())
                        ).ToList();
                    }
                }
               
                var jsonData = new
                {
                    Draw = draw,
                    recordsFiltered = totalRecord,
                    recordsTotal = totalRecord,
                    data = banks,
                };

                return Json(jsonData);

            }
            catch (Exception ex)
            {
                resp.hasError = true;
                resp.error = ex.Message;
            }

            return Json(resp);

        }

        [HttpPost]
        public async Task<JsonResult> Edit(EditBanks req)
        {
            
            try
            {
                if (req == null)
                {
                    throw new Exception("Kindly enter bank name");
                }
                else
                {
                    await _repoWrapper.BankRepo.EditBank(req);
                }
            }
            catch (Exception ex)
            {
                resp.hasError = true;
                resp.error = ex.Message;
            }

            return Json(resp);
        }


        [HttpGet]
        public async Task<IActionResult> EditModal(int BankID)
        {
            EditBanks bank = new EditBanks();
            try
            {
                if (BankID >= 1)
                {
                    bank = await _repoWrapper.BankRepo.GetBank(BankID);
                    resp.response = true;
                }
            }
            catch (Exception ex)
            {
                resp.hasError = true;
                resp.error = ex.Message;
            }
            return PartialView("_Edit",bank);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int BankID)
        {
            EditBanks bank = new EditBanks();
            try
            {
                if (BankID >= 1)
                {
                    bank = await _repoWrapper.BankRepo.GetBank(BankID);
                }
            }
            catch (Exception ex)
            {
                resp.hasError = true;
                resp.error = ex.Message;
            }
            return PartialView("_Edit", bank);
        }

    }
}
