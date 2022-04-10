using MongoDB.Bson;

namespace MongoDB1.Models
{
    public class MongoCrudModel
    {
        public MongoCrudModel()
        {
            List = new List<MongoModel>();
        }
        public int DeleteID { get; set; }
        public int UpdateID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Number { get; set; }
        public List<MongoModel> List { get; set; }
    }
}
