using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CarPark.Entities.Concrete
{
    public class BaseModel
    {
        [BsonId]
        public ObjectId Id { get; set; }
    }
}
