using Car_Specs.Services.Database;
using AutoFixture;
using MongoDB.Driver;
using Moq;
using Car_Specs.Models.Data;
using Car_Specs.Services.Brand;
using System.Linq.Expressions;

namespace Car_Specs.Test.Test.Service
{
    public class BrandServiceTest
    {
        private readonly Mock<IDatabaseContext> _mockDatabaseContext;
        private readonly Fixture _fixture = new Fixture();

        public BrandServiceTest()
        {
            _mockDatabaseContext = new Mock<IDatabaseContext>();
        }
        [Fact]
        public async Task GetAllBrandsService_Should_ReturnAllVehicles()
        {
            var mockBrands = _fixture.Create<List<BrandModel>>();
            var service = new BrandService(_mockDatabaseContext.Object);
            var result = await service.getAllBrands();

            _mockDatabaseContext.Setup(collection =>
            collection.Brands
            .FindAsync(It.IsAny<Expression<Func<BrandModel, bool>>>(), It
            .IsAny<FindOptions<BrandModel, BrandModel>>(), default)
            ).ReturnsAsync((IAsyncCursor<BrandModel>)mockBrands);

            Assert.Equal(result, mockBrands);
        }
    }
}
