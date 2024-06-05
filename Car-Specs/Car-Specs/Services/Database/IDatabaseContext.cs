using Car_Specs.Models.Data;
using MongoDB.Driver;

namespace Car_Specs.Services.Database
{
    public interface IDatabaseContext
    {
        IMongoCollection<BrandModel> Brands { get; }
    }
}
