using Matrix.Core.Application.DTOs;
using Matrix.Core.Application;
using Microsoft.AspNetCore.Mvc;

namespace Matrix.Controllers
{
    public class ModelController : Controller
    {
        private IRepositoryWrapper _repoWrapper;

        JSONResultResp resp = new JSONResultResp();
        public ModelController(IRepositoryWrapper repoWrapper)
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
        public async Task<JsonResult> Add(ModelDTO req)
        {

            try
            {
                if (req == null)
                    throw new Exception("Kindly enter model name");
                else
                {
                    _repoWrapper.ModelRepo.AddModel(req);
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
        public async Task<JsonResult> GetModels()
        {
            try
            {
                List<GetModels> Model = await _repoWrapper.ModelRepo.GetModel();
                var jsonData = new
                {
                    draw = Request.Form["draw"].ToString(),
                    recordsFiltered = Model.Count(),
                    recordsTotal = Model.Count(),
                    data = Model,
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
        public async Task<JsonResult> Edit(EditModel req)
        {

            try
            {
                if (req == null)
                {
                    throw new Exception("Kindly enter model name");
                }
                else
                {
                    await _repoWrapper.ModelRepo.EditModel(req);
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
        public async Task<IActionResult> EditModal(int ModelID)
        {
            EditModel Model = new EditModel();
            try
            {
                if (ModelID >= 1)
                {
                    Model = await _repoWrapper.ModelRepo.GetModel(ModelID);
                    resp.response = true;
                }
            }
            catch (Exception ex)
            {
                resp.hasError = true;
                resp.error = ex.Message;
            }
            return PartialView("_Edit", Model);
        }

        //[HttpGet]
        //public async Task<IActionResult> Delete(int ModelID)
        //{
        //    EditModels Model = new EditModels();
        //    try
        //    {
        //        if (ModelID >= 1)
        //        {
        //            Model = await _repoWrapper.ModelRepo.GetModel(ModelID);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        resp.hasError = true;
        //        resp.error = ex.Message;
        //    }
        //    return PartialView("_Edit", Model);
        //}
    }
}
