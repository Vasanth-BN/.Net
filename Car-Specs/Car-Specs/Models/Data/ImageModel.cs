using MongoDB.Bson.Serialization.Attributes;

namespace CarSpecs.Models.Data
{
    public class ImageModel
    {
        [BsonElement("altText")]
        public string AltText { get; set; }

        [BsonElement("src")]
        public string Src { get; set; }
    }
}
