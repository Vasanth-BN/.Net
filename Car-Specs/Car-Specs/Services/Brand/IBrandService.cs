using CarSpecs.Models.Api;
using CarSpecs.Models.Data;

namespace CarSpecs.Services.Brand
{
    public interface IBrandService
    {
        Task<List<BrandModel>> getAllBrands();

        Task<BrandModel> getBrandById(string brandId);

        Task<BrandModel> createBrand(BrandDTO brandDTO);

        Task<long> deleteBrand(string id);
    }
}
