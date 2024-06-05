using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Car_Specs.Models.Data
{
    public class BrandModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("brandName")]
        public string BrandName { get; set; }

        [BsonElement("brandBg")]
        public ImageModel BrandBg { get; set; }

        [BsonElement("description")]
        public string? Description { get; set; }

        [BsonElement("brandLogo")]
        public ImageModel BrandLogo { get; set; }

        [BsonElement("models")]
        public List<ModelsModel> Models { get; set; }

    }

}
