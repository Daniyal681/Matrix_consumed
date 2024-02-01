using Matrix.Core.Application.DTOs;
using Matrix.Core.Application;
using Microsoft.AspNetCore.Mvc;

namespace Matrix.Controllers
{
    public class SupplierController : Controller
    {
        private IRepositoryWrapper _repoWrapper;

        JSONResultResp resp = new JSONResultResp();
        public SupplierController(IRepositoryWrapper repoWrapper)
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
        public async Task<JsonResult> Add(SupplierDTO req)
        {

            try
            {
                if (req == null)
                    throw new Exception("Kindly enter Supplier name");
                else
                {
                    _repoWrapper.SupplierRepo.AddSupplier(req);
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
        public async Task<JsonResult> GetSupplier()
        {
            //try
            //{
            //    List<GetSuppliers> supplier = await _repoWrapper.SupplierRepo.GetSupplier();
            //    var jsonData = new
            //    {
            //        draw = Request.Form["draw"].ToString(),
            //        recordsFiltered = supplier.Count(),
            //        recordsTotal = supplier.Count(),
            //        data = supplier,
            //    };

            //    return Json(jsonData);

            //}
            //catch (Exception ex)
            //{
            //    resp.hasError = true;
            //    resp.error = ex.Message;
            //}

            //return Json(resp);

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

                List<GetSuppliers> supplier = await _repoWrapper.SupplierRepo.GetSupplier();

                if (!string.IsNullOrEmpty(sortColumn) && !string.IsNullOrEmpty(sortColumnDir))
                {
                    // Apply sorting based on the selected column and direction
                    if (sortColumnDir.ToLower() == "asc")
                    {
                        supplier = supplier.OrderBy(p => p.SupplierID).ToList();
                    }
                    else
                    {
                        supplier = supplier.OrderByDescending(p => p.SupplierID).ToList();
                    }
                }

                int totalRecord = supplier.Count();
                if (pageSize >= 0)
                {
                    supplier = supplier.Skip(skip).Take(pageSize).ToList();
                }
                if (!string.IsNullOrEmpty(searchValue))
                {
                    if (searchValue.ToLower().Contains("rem"))
                        supplier = supplier.Where(x => x.IsActive == EStatus.Deactive).ToList();
                    else if (searchValue.ToLower().Contains("act"))
                        supplier = supplier.Where(x => x.IsActive == EStatus.Active).ToList();
                    else
                    {
                        supplier = supplier.Where(x =>
                            x.SupplierID.ToString().Contains(searchValue.ToLower()) ||
                            x.SupplierName.ToLower().Contains(searchValue.ToLower())
                        ).ToList();
                    }
                }

                var jsonData = new
                {
                    Draw = draw,
                    recordsFiltered = totalRecord,
                    recordsTotal = totalRecord,
                    data = supplier,
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
        public async Task<JsonResult> Edit(EditSuppliers req)
        {

            try
            {
                if (req == null)
                {
                    throw new Exception("Kindly enter supplier name");
                }
                else
                {
                    await _repoWrapper.SupplierRepo.EditSupplier(req);
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
        public async Task<IActionResult> EditModal(int SuppliersID)
        {
            EditSuppliers supplier = new EditSuppliers();
            try
            {
                if (SuppliersID >= 1)
                {
                    supplier = await _repoWrapper.SupplierRepo.Getsupplier(SuppliersID);
                    resp.response = true;
                }
            }
            catch (Exception ex)
            {
                resp.hasError = true;
                resp.error = ex.Message;
            }
            return PartialView("_Edit", supplier);
        }

        //[HttpGet]
        //public async Task<IActionResult> Delete(int SuppliersID)
        //{
        //    EditSuppliers supplier = new EditSuppliers();
        //    try
        //    {
        //        if (SuppliersID >= 1)
        //        {
        //            supplier = await _repoWrapper.SupplierRepo.GetSupplier(SuppliersID);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        resp.hasError = true;
        //        resp.error = ex.Message;
        //    }
        //    return PartialView("_Edit", supplier);
        //}
    }
}
