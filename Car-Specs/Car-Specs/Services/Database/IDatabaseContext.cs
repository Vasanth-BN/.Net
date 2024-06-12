using CarSpecs.Models.Data;
using MongoDB.Driver;

namespace CarSpecs.Services.Database
{
    public interface IDatabaseContext
    {
        IMongoCollection<BrandModel> Brands { get; }
    }
}
