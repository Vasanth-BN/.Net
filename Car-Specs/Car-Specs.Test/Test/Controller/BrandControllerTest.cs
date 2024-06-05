using AutoFixture;
using Car_Specs.Controllers;
using Car_Specs.Models.Data;
using Car_Specs.Services.Brand;
using Microsoft.AspNetCore.Mvc;
using Moq;
using FluentAssertions;


namespace Car_Specs.Test.Test.Controller
{
    public class BrandControllerTest
    {
        private readonly Fixture _fixture = new Fixture();

        [Fact]
        public async Task shouldReturnOn_GetAllBrands_AndStatus200()
        {
            var mockBrandService = new Mock<IBrandService>();
            var mockBrand = _fixture.Create<List<BrandModel>>();
            mockBrandService.Setup(service => service.getAllBrands()).ReturnsAsync(mockBrand);

            var testController = new BrandController(mockBrandService.Object);
            var result = await testController.GetAllBrands();

            mockBrandService.Verify(service => service.getAllBrands(), Times.Once());

            result
                .Should().BeOfType<OkObjectResult>().Which.Value
                .Should().BeOfType<List<BrandModel>>().And.Subject.As<List<BrandModel>>()
                .Should().BeEquivalentTo(mockBrand);
        }
    }
}
