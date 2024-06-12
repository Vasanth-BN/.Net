using AutoMapper;
using CarSpecs.Models.Api;
using CarSpecs.Models.Data;
using CarSpecs.Services.Database;
using MongoDB.Driver;

namespace CarSpecs.Services.Brand
{
    public class BrandService : IBrandService
    {
        IMapper _mapper;
        IDatabaseContext _databaseContext;

        public BrandService(IMapper mapper, IDatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
            _mapper = mapper;
        }

        public async Task<List<BrandModel>> getAllBrands()
        {
            return await _databaseContext.Brands.Find(brand => true).ToListAsync();
        }

        public async Task<BrandModel> getBrandById(string brandId)
        {
            return await _databaseContext.Brands.Find(brand => brand.Id == brandId).FirstOrDefaultAsync();
        }

        public async Task<BrandModel> createBrand(BrandDTO brandDTO)
        {
            var brandData = _mapper.Map<BrandModel>(brandDTO);
            await _databaseContext.Brands.InsertOneAsync(brandData);
            return brandData;
        }

        public async Task<long> deleteBrand(string id)
        {
            var brand = await _databaseContext.Brands.DeleteOneAsync(brand => brand.Id == id);
            return brand.DeletedCount;
        }
    }
}
