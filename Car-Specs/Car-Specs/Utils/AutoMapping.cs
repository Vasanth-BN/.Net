using AutoMapper;
using CarSpecs.Models.Api;
using CarSpecs.Models.Data;

namespace CarSpecs.Utils
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<BrandModel, BrandDTO>();
        }
    }
}
