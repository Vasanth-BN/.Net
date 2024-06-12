using CarSpecs.Models.Data;

namespace CarSpecs.Models.Api
{
    public class BrandDTO
    {
        public string BrandName { get; set; }

        public ImageDTO BrandBg { get; set; }

        public string Description { get; set; }

        public ImageDTO BrandLogo { get; set; }

        public List<ModelDTO> Models { get; set; }
    }
}
