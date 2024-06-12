using CarSpecs.Models.Data;
using MongoDB.Bson.Serialization.Attributes;

namespace CarSpecs.Models.Api
{
    public class ModelDTO
    {

        public string ModelId { get; set; }

        public string ModelName { get; set; }

        public ImageModel FrontImage { get; set; }

        public ImageModel RearImage { get; set; }

        public string Description { get; set; }

        public string Segment { get; set; }

        public string Engine { get; set; }

        public string EngineType { get; set; }

        public string FuelType { get; set; }

        public string HorsePower { get; set; }

        public string Torque { get; set; }

        public string Transmission { get; set; }

        public string Length { get; set; }

        public string Width { get; set; }

        public string Height { get; set; }

        public string Price { get; set; }
    }
}
