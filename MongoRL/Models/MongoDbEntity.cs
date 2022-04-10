using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoRL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoRL.Models
{
    public abstract class MongoDbEntity : IEntity<string>
    {
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonId]
        [BsonElement(Order = 0)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.DateTime)]
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        [BsonElement(Order = 101)]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
