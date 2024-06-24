//using CarSpecs.Services.Database;
//using AutoFixture;
//using MongoDB.Driver;
//using Moq;
//using CarSpecs.Models.Data;
//using CarSpecs.Services.Brand;
//using AutoMapper;
//using CarSpecs.Models.Api;

//namespace CarSpecs.Test.Test.Service
//{
//    public class BrandServiceTest
//    {
//        private readonly Mock<IDatabaseContext> _mockDatabaseContext;
//        private readonly Fixture _fixture = new Fixture();
//        private readonly Mock<IMapper> _mockMapper;


//        public BrandServiceTest()
//        {
//            _mockDatabaseContext = new Mock<IDatabaseContext>();
//            _mockMapper = new Mock<IMapper>();
//        }
//        [Fact]
//        public async Task GetAllBrandsService_Should_ReturnAllVehicles()
//        {
//            var mockBrands = _fixture.Create<List<BrandModel>>();
//            var mockCursor = new Mock<IAsyncCursor<BrandModel>>();
//            var mockCollection = new Mock<IMongoCollection<BrandModel>>();

//            mockCursor.SetupSequence(_ => _.MoveNextAsync(default))
//              .ReturnsAsync(true)
//              .ReturnsAsync(false);
//            mockCursor.Setup(_ => _.Current).Returns(mockBrands);

//            mockCollection.Setup(collection => collection.FindAsync(
//                It.IsAny<FilterDefinition<BrandModel>>(),
//                It.IsAny<FindOptions<BrandModel, BrandModel>>(),
//                default))
//                .ReturnsAsync(mockCursor.Object);


//            _mockDatabaseContext.Setup(brand => brand.Brands).Returns(mockCollection.Object);

//            var service = new BrandService(_mockMapper.Object, _mockDatabaseContext.Object);

//            var result = await service.getAllBrands();

//            Assert.Equal(result, mockBrands);
//        }

//        [Fact]
//        public async Task GetBrandById_ShouldReturn_Brand_ById()
//        {
//            var mockBrand = _fixture.Create<BrandModel>();
//            var mockCursor = new Mock<IAsyncCursor<BrandModel>>();
//            var mockCollection = new Mock<IMongoCollection<BrandModel>>();
//            var mockId = _fixture.Create<string>();

//            mockCursor.SetupSequence(_ => _.MoveNextAsync(default))
//                .ReturnsAsync(true)
//                .ReturnsAsync(false);
//            mockCursor.Setup(_ => _.Current).Returns(new List<BrandModel> { mockBrand });

//            mockCollection.Setup(collection => collection.FindAsync(
//                It.IsAny<FilterDefinition<BrandModel>>(),
//                It.IsAny<FindOptions<BrandModel, BrandModel>>(), default))
//                .ReturnsAsync(mockCursor.Object);

//            _mockDatabaseContext.Setup(brand => brand.Brands).Returns(mockCollection.Object);

//            var brandService = new BrandService(_mockMapper.Object, _mockDatabaseContext.Object);

//            var result = await brandService.getBrandById(mockId);

//            Assert.Equal(result, mockBrand);
//        }

//        [Fact]
//        public async Task CreateBrand_Should_InsertBrand()
//        {
//            var mockBrandDTO = _fixture.Create<BrandDTO>();
//            var mockBrand = _fixture.Create<BrandModel>();
//            var mockCollection = new Mock<IMongoCollection<BrandModel>>();

//            _mockMapper.Setup(mapper => mapper.Map<BrandModel>(mockBrandDTO)).Returns(mockBrand);
//            _mockDatabaseContext.Setup(database => database.Brands).Returns(mockCollection.Object);
//            mockCollection.Setup(collection => collection.InsertOneAsync(mockBrand, null, default))
//                  .Returns(Task.CompletedTask);

//            var brandService = new BrandService(_mockMapper.Object, _mockDatabaseContext.Object);
//            var result = await brandService.createBrand(mockBrandDTO);

//            mockCollection.Verify(collection => collection.InsertOneAsync(mockBrand, null, default), Times.Once());

//            Assert.Equal(result, mockBrand);
//        }

//        [Fact]
//        public async Task DeleteBrand_Should_DeleteBrand()
//        {
//            var message = _fixture.Create<int>();
//            var mockId = _fixture.Create<string>();
//            var mockCollection = new Mock<IMongoCollection<BrandModel>>();

//            _mockDatabaseContext.Setup(database => database.Brands).Returns(mockCollection.Object);
//            var deleteResult = new DeleteResult.Acknowledged(message);

//            mockCollection.Setup(collection => collection.DeleteOneAsync(It.IsAny<FilterDefinition<BrandModel>>(), default))
//            .ReturnsAsync(deleteResult);

//            var brandService = new BrandService(_mockMapper.Object, _mockDatabaseContext.Object);
//            var result = await brandService.deleteBrand(mockId);

//            mockCollection.Verify(collection => collection.DeleteOneAsync(It.IsAny<FilterDefinition<BrandModel>>(), default));

//            Assert.Equal(result, message);
//        }
//    }
//}
