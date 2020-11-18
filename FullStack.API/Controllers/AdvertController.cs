using FullStack.API.Services;
using FullStack.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FullStack.API.Controllers
{
    [Route("api/adverts")]
    [ApiController]
    public class AdvertsController : ControllerBase
    {
        private IAdvertService _advertService;
        public AdvertsController(IAdvertService advertService)
        {
            _advertService = advertService;
        }

        [Authorize]
        [HttpGet]
        public IActionResult GetAdverts()
        {
            var adverts = _advertService.GetAdverts();
            return Ok(adverts);
        }

        [Authorize]
        [HttpGet("{id}")]
        public ActionResult<AdvertModel> GetInvoice(int id)
        {
            var advert = _advertService.GetAdvert(id);

            return advert;
        }

        [Authorize]
        [HttpPut("{id}")]
        public ActionResult<AdvertModel> UpdateAdvert(int id, AdvertModel advert)
        {
            if (id != advert.AdvertId)
            {
                return BadRequest();
            }

            var updatedResult = _advertService.UpdateAdvert(advert);

            return updatedResult;
        }

        [Authorize]
        [HttpPost]
        public ActionResult<AdvertModel> CreateInvoice(AdvertModel advert)
        {
            return _advertService.CreateAdvert(advert);
        }

        [Authorize]
        [HttpDelete("{id}")]
        public ActionResult<AdvertModel> DeleteInvoice(int id)
        {
            var advert = _advertService.GetAdvert(id);
            if (advert == null)
            {
                return NotFound();
            }

            _advertService.DeleteAdvert(id);

            return Ok(advert);
        }
    }
}
