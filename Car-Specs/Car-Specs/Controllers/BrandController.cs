using Car_Specs.Services.Brand;
using Microsoft.AspNetCore.Mvc;

namespace Car_Specs.Controllers
{
    [Route("/")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _brandService;
        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet("brands")]
        public async Task<IActionResult> GetAllBrands()
        {   
            var brands = await _brandService.getAllBrands();
            return Ok(brands);
        }
    }
}
