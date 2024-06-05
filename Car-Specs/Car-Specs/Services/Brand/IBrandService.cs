using Car_Specs.Models.Data;

namespace Car_Specs.Services.Brand
{
    public interface IBrandService
    {
        Task<List<BrandModel>> getAllBrands();
    }
}
