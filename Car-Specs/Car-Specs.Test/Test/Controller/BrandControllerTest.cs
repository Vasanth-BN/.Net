//using AutoFixture;
//using CarSpecs.Controllers;
//using CarSpecs.Models.Data;
//using CarSpecs.Services.Brand;
//using Microsoft.AspNetCore.Mvc;
//using Moq;
//using FluentAssertions;
//using CarSpecs.Models.Api;


//namespace CarSpecs.Test.Test.Controller
//{
//    public class BrandControllerTest
//    {
//        private readonly Fixture _fixture = new Fixture();

//        [Fact]
//        public async Task ShouldReturnOn_GetAllBrands_AndStatus200()
//        {
//            var mockBrandService = new Mock<IBrandService>();
//            var mockBrand = _fixture.Create<List<BrandModel>>();
//            mockBrandService.Setup(service => service.getAllBrands()).ReturnsAsync(mockBrand);

//            var testController = new BrandController(mockBrandService.Object);
//            var result = await testController.GetAllBrands();

//            mockBrandService.Verify(service => service.getAllBrands(), Times.Once());

//            result
//                .Should().BeOfType<OkObjectResult>().Which.Value
//                .Should().BeOfType<List<BrandModel>>().And.Subject.As<List<BrandModel>>()
//                .Should().BeEquivalentTo(mockBrand);
//        }

//        [Fact]
//        public async Task ShouldReturnOn_GetBrandById_AndStatus200()
//        {
//            var mockBrandService = new Mock<IBrandService>();
//            var mockBrand = _fixture.Create<BrandModel>();
//            var mockId = _fixture.Create<string>();

//            mockBrandService.Setup(service => service.getBrandById(mockId)).ReturnsAsync(mockBrand);

//            var brandController = new BrandController(mockBrandService.Object);
//            var result = await brandController.GetBrandById(mockId);

//            mockBrandService.Verify(service => service.getBrandById(mockId), Times.Once());

//            result.Should().BeOfType<OkObjectResult>().Which.Value.Should().Be(mockBrand);
//        }

//        [Fact]
//        public async Task ShouldReturnOn_GetBrandById_AndStatus404()
//        {
//            var mockBrandService = new Mock<IBrandService>();
//            var mockId = _fixture.Create<string>();

//            mockBrandService.Setup(service => service.getBrandById(mockId)).ReturnsAsync(null as BrandModel);

//            var brandController = new BrandController(mockBrandService.Object);
//            var result = await brandController.GetBrandById(mockId);

//            mockBrandService.Verify(service => service.getBrandById(mockId), Times.Once());

//            result.Should().BeOfType<NotFoundResult>();
//        }

//        [Fact]
//        public async Task ShouldReturnOn_CreationOfBrand_Status201()
//        {
//            var mockBrandService = new Mock<IBrandService>();
//            var mockBrand = _fixture.Create<BrandModel>();
//            var mockBrandDTO = _fixture.Create<BrandDTO>();

//            mockBrandService.Setup(service => service.createBrand(mockBrandDTO)).ReturnsAsync(mockBrand);

//            var brandController = new BrandController(mockBrandService.Object);
//            var result = await brandController.CreateBrand(mockBrandDTO);

//            mockBrandService.Verify(service => service.createBrand(mockBrandDTO), Times.Once());

//            result.Should().BeOfType<CreatedAtActionResult>().Which.Value.Should().Be(mockBrand);
//        }

//        [Fact]
//        public async Task ShouldReturnOn_CreationOfBrand_InvalidObject_AndStatusAs404()
//        {
//            var mockBrandService = new Mock<IBrandService>();
//            var mockBrand = _fixture.Create<BrandModel>();
//            var mockBrandDTO = _fixture.Create<BrandDTO>();

//            mockBrandService.Setup(service => service.createBrand(mockBrandDTO)).ReturnsAsync(null as BrandModel);

//            var mockBrandController = new BrandController(mockBrandService.Object);
//            var result = await mockBrandController.CreateBrand(mockBrandDTO);

//            mockBrandService.Verify(service => service.createBrand(mockBrandDTO), Times.Once());

//            result.Should().BeOfType<NotFoundResult>();
//        }

//        [Fact]
//        public async Task ShouldReturnOn_DeleteBrand_AndStatus200()
//        {
//            var mockBrandService = new Mock<IBrandService>();
//            var mockId = _fixture.Create<string>();
//            var count = _fixture.Create<long>();

//            mockBrandService.Setup(service => service.deleteBrand(mockId)).ReturnsAsync(count);

//            var mockBrandController = new BrandController(mockBrandService.Object);
//            var result = await mockBrandController.DeleteBrand(mockId);

//            mockBrandService.Verify(service => service.deleteBrand(mockId), Times.Once());

//            result.Should().BeOfType<OkObjectResult>();
//        }

//        [Fact]
//        public async Task ShouldReturnOn_DeleteBrand_IdNotFound_AndStatus404()
//        {
//            var mockBrandService = new Mock<IBrandService>();
//            var mockId = _fixture.Create<string>();

//            mockBrandService.Setup(service => service.deleteBrand(mockId)).ReturnsAsync(0);

//            var mockBrandController = new BrandController(mockBrandService.Object);
//            var result = await mockBrandController.DeleteBrand(mockId);

//            mockBrandService.Verify(service => service.deleteBrand(mockId), Times.Once());

//            result.Should().BeOfType<NotFoundResult>();
//        }
//    }
//}
