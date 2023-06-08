using AutoShop_Bll;
using AutoShop_Dal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoShop_API.Controllers
{
    [ApiController]
    [Produces("application/json", "application/xml")]
    public class DetailsController : ControllerBase
    {
        private readonly IDetailsService _detailsService;

        public DetailsController(IDetailsService detailsService)
        {
            this._detailsService = detailsService ?? throw new ArgumentNullException(nameof(detailsService));
        }

        [HttpGet("api/details")]
        public async Task<IActionResult> GetDetails()
        {
            return Ok(await _detailsService.GetDictionaryOfProductsAsync());
        }
    }
}
