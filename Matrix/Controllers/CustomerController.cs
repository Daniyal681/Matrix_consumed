using Matrix.Core.Application;
using Matrix.Core.Application.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Matrix.Controllers
{
    public class CustomerController : Controller
    {
        JSONResultResp resp = new JSONResultResp();
        private IRepositoryWrapper _repoWrapper;

        public CustomerController(IRepositoryWrapper repoWrapper)
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
            List<GetBrandsDTO> req = new List<GetBrandsDTO>();
            req = await _repoWrapper.BrandRepo.GetBrands();
            return PartialView("_Add", req);
        }

        [HttpPost]
        public async Task<JsonResult> GetCustomer()
        {
            try
            {
                List<GetCustomerDetails> customer = await _repoWrapper.CustomerRepo.GetCustomerDetails();
                var jsonData = new
                {
                    draw = Request.Form["draw"].ToString(),
                    recordsFiltered = customer.Count(),
                    recordsTotal = customer.Count(),
                    data = customer,
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
        public async Task<JsonResult> AddCustomer(AddCustomerDetails req)
        {
            try
            {
                if (req == null)
                    throw new Exception("Kindly enter customer name");
                else
                {
                    _repoWrapper.CustomerRepo.AddCustomerDetails(req);
                }
            }
            catch (Exception ex)
            {
                resp.hasError = true;
                resp.error = ex.Message;
            }

            return Json(resp);
        }

        public async Task<JsonResult> GetAreaByID(int AreaID)
        {
            try
            {
                return Json(new { hasError = false, response = await _repoWrapper.AreasRepo.GetArea(AreaID) });
            }
            catch (Exception ex)
            {
                return Json(new { hasError = true, error = ex.Message });
            }

        }

        //[HttpPost]
        //public async Task<JsonResult> AddCustomerDetails(AddCustomerDetails req)
        //{
        //    try
        //    {
        //        if (req == null)
        //            throw new Exception("Kindly enter customer name");
        //        else
        //        {
        //            _repoWrapper.CustomerRepo.AddCustomerDetails(req);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        resp.hasError = true;
        //        resp.error = ex.Message;
        //    }

        //    return Json(resp);
        //}

        //[HttpPost]
        //public async Task<JsonResult> EditCustomer(EditCustomerDTO req)
        //{

        //    try
        //    {
        //        if (req == null)
        //        {
        //            throw new Exception("Kindly enter customer name");
        //        }
        //        else
        //        {
        //            await _repoWrapper.CustomerRepo.EditCustomer(req);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        resp.hasError = true;
        //        resp.error = ex.Message;
        //    }

        //    return Json(resp);
        //}

        [HttpPost]
        public async Task<JsonResult> EditCustomerDetails(EditCustomerDetails req)
            {

            try
            {
                if (req == null)
                {
                    throw new Exception("Kindly enter customer name");
                }
                else
                {
                  await _repoWrapper.CustomerRepo.EditCustomerDetails(req);
                }
            }
            catch (Exception ex)
            {
                resp.hasError = true;
                resp.error = ex.Message;
            }

            return Json(resp);
        }

        //[HttpGet]
        //public async Task<IActionResult> EditCustomerModal(int CustomerID)
        //{
        //    GetCustomerDetails customer = new GetCustomerDetails();
        //    try
        //    {
        //        if (CustomerID >= 1)
        //        {
        //            customer = await _repoWrapper.CustomerRepo.GetCustomerDetail(CustomerID);
        //            resp.response = true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        resp.hasError = true;
        //        resp.error = ex.Message;
        //    }
        //    return PartialView("_EditCustomer", customer);
        //} 
        
        [HttpGet]
        public async Task<IActionResult> EditCustomerDetailsModal(int CustomerID)
        {
            GetCustomerDetails customerdetails = new GetCustomerDetails();
            try
            {
                if (CustomerID >= 1)
                {
                    customerdetails = await _repoWrapper.CustomerRepo.GetCustomerDetail(CustomerID);
                    resp.response = true;
                }
            }
            catch (Exception ex)
            {
                resp.hasError = true;
                resp.error = ex.Message;
            }
            return PartialView("_Edit", customerdetails);
        }
    }
}
