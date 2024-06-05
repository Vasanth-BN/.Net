using Car_Specs.Models.Data;
using Car_Specs.Services.Database;
using MongoDB.Driver;

namespace Car_Specs.Services.Brand
{
    public class BrandService : IBrandService
    {
        IDatabaseContext _databaseContext;

        public BrandService(IDatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<List<BrandModel>> getAllBrands()
        {
            return await _databaseContext.Brands.Find(brand => true).ToListAsync();
        }
    }
}
