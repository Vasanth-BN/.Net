using MongoDB.Bson.Serialization.Attributes;

namespace CarSpecs.Models.Data
{
    public class ModelsModel
    {

        [BsonElement("modelId")]
        public string ModelId { get; set; }

        [BsonElement("modelName")]
        public string ModelName { get; set; }

        [BsonElement("frontImage")]
        public ImageModel FrontImage { get; set; }

        [BsonElement("rearImage")]
        public ImageModel RearImage { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        [BsonElement("segment")]
        public string Segment { get; set; }

        [BsonElement("engine")]
        public string Engine { get; set; }

        [BsonElement("engineType")]
        public string EngineType { get; set; }

        [BsonElement("fuelType")]
        public string FuelType { get; set; }

        [BsonElement("horsePower")]
        public string HorsePower { get; set; }

        [BsonElement("torque")]
        public string Torque { get; set; }

        [BsonElement("transmission")]
        public string Transmission { get; set; }

        [BsonElement("length")]
        public string Length { get; set; }

        [BsonElement("width")]
        public string Width { get; set; }

        [BsonElement("height")]
        public string Height { get; set; }

        [BsonElement("price")]
        public string Price { get; set; }

    }
}
