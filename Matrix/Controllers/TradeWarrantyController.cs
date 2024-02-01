using Matrix.Core.Application.DTOs;
using Matrix.Core.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Matrix.Controllers
{
    public class TradeWarrantyController : Controller
    {
        JSONResultResp resp = new JSONResultResp();
        private IRepositoryWrapper _repoWrapper;

        public TradeWarrantyController(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return PartialView("_Add");
        }

        [HttpPost]
        public async Task<JsonResult> GetTradeWarranty()
        {
            try
            {
                List<GetTradeWarrantyRequest> tradewarranty = await _repoWrapper.TradeWarrantyRepo.GetTradeWarranty();
                var jsonData = new
                {
                    draw = Request.Form["draw"].ToString(),
                    recordsFiltered = tradewarranty.Count(),
                    recordsTotal = tradewarranty.Count(),
                    data = tradewarranty,
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
        public async Task<JsonResult> Add(TradeWarrantyRequest req)
        {
            try
            {
                if (req == null)
                    throw new Exception("Kindly enter local purchase name");
                else
                {
                    _repoWrapper.TradeWarrantyRepo.GenerateTradeWarranty(req);
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
        public async Task<IActionResult> EditModal(int RecID)
        {
            EditTradeWarranty tradewarranty = new EditTradeWarranty();
            try
            {
                if (RecID >= 1)
                {
                    tradewarranty = await _repoWrapper.TradeWarrantyRepo.Gettradewarranty(RecID);
                    resp.response = true;
                }
            }
            catch (Exception ex)
            {
                resp.hasError = true;
                resp.error = ex.Message;
            }
            return PartialView("_Edit", tradewarranty);
        }

        [HttpPost]
        public async Task<JsonResult> Edit(EditTradeWarranty req)
        {
            try
            {
                if (req == null)
                {
                    throw new Exception("Kindly enter local purchase name");
                }
                else
                {
                    await _repoWrapper.TradeWarrantyRepo.EditTradeWarranty(req);
                }
            }
            catch (Exception ex)
            {
                resp.hasError = true;
                resp.error = ex.Message;
            }

            return Json(resp);
        }

        public async Task<JsonResult> GetModels(string search = "")
        {
            try
            {
                List<GetModels> lst = await _repoWrapper.ModelRepo.GetModel();
                
                List<SelectDropDown> resp = lst.Select(s => new SelectDropDown
                {
                    id = s.ModelID,
                    text = s.ModelName 
                }).ToList();

                if (!string.IsNullOrEmpty(search))
                {
                    resp = resp.Where(x => x.text.Contains(search)).ToList();
                }
                return Json(new { results = resp });
            }
            catch (Exception ex)
            {
                return Json(new { hasError = true, error = ex.Message });
            }
        }
    }
}
