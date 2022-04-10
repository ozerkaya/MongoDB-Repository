using MongoDB.Bson;

namespace MongoDB1.Models
{
    public class MongoModel
    {
        public ObjectId _id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Number { get; set; }
    }
}
