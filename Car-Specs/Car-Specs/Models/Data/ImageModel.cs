using MongoDB.Bson.Serialization.Attributes;

namespace Car_Specs.Models.Data
{
    public class ImageModel
    {
        [BsonElement("altText")]
        public string? AltText { get; set; }

        [BsonElement("src")]
        public string? Src { get; set; }
    }
}
