using Car_Specs.Models.Configuration;
using Car_Specs.Models.Data;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Car_Specs.Services.Database
{
    public class DatabaseContext : IDatabaseContext
    {
        private readonly IMongoCollection<BrandModel> _brandCollection;
        public DatabaseContext(IOptions<CarsDataBaseSettings> dbSettings, IMongoClient client)
        {
            var database = client.GetDatabase(dbSettings.Value.DatabaseName);
            _brandCollection = database.GetCollection<BrandModel>(dbSettings.Value.CollectionName);
        }

        public IMongoCollection<BrandModel> Brands =>
            _brandCollection;
    }
}
