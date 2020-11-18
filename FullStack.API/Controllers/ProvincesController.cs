using FullStack.API.Services;
using FullStack.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FullStack.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvincesController : ControllerBase
    {
        private IProvinceService _provinceService;
        public ProvincesController(IProvinceService provinceService)
        {
            _provinceService = provinceService;
        }

        [Authorize]
        [HttpGet]
        public IActionResult GetProvinces()
        {
            var provinces = _provinceService.GetProvinces();
            return Ok(provinces);
        }

        [Authorize]
        [HttpGet("{id}")]
        public ActionResult<ProvinceModel> GetProvince(int id)
        {
            var province = _provinceService.GetProvince(id);

            return province;
        }

        [Authorize]
        [HttpGet("{provinceName}/cities")]
        public ActionResult<ProvinceModel> GetProvinceCity(string provinceName)
        {
            var city = _provinceService.GetProvinceCity(provinceName);

            return city;
        }

        [Authorize]
        [HttpPut("{id}")]
        public ActionResult<ProvinceModel> UpdateAdvert(int id, ProvinceModel province)
        {
            if (id != province.ProvinceId)
            {
                return BadRequest();
            }

            var updatedResult = _provinceService.UpdateProvince(province);

            return updatedResult;
        }

        [Authorize]
        [HttpPost]
        public ActionResult<ProvinceModel> CreateInvoice(ProvinceModel province)
        {
            _provinceService.AddProvince(province);

            return CreatedAtAction("GetProvince", new { id = province.ProvinceId }, province);
        }

        [Authorize]
        [HttpDelete("{id}")]
        public ActionResult<ProvinceModel> DeleteProvince(int id)
        {
            var province = _provinceService.GetProvince(id);
            if (province == null)
            {
                return NotFound();
            }

            _provinceService.DeleteProvince(id);

            return Ok(province);
        }
    }
}
