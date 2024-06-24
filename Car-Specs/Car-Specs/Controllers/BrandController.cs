using CarSpecs.Models.Api;
using CarSpecs.Services.Brand;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarSpecs.Controllers
{
    [Route("/carSpecs/brands")]
    [ApiController]
    [Authorize]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _brandService;
        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBrands()
        {
            var brands = await _brandService.getAllBrands();
            return Ok(brands);
        }
        [HttpGet("/{brandId}")]
        public async Task<IActionResult> GetBrandById(string brandId)
        {
            var brand = await _brandService.getBrandById(brandId);
            return brand == null ? NotFound() : Ok(brand);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBrand(BrandDTO brandDTO)
        {
            var brand = await _brandService.createBrand(brandDTO);
            return brand == null ? NotFound() : CreatedAtAction(nameof(brand), new { id = brand.Id }, brand);
        }

        [HttpDelete("/{brandId}")]
        public async Task<IActionResult> DeleteBrand(string id)
        {
            var count = await _brandService.deleteBrand(id);
            return count == 0 ? NotFound() : Ok(count);
        }
    }
}
