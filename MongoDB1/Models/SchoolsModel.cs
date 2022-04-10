using MongoRL.Poco;

namespace MongoDB1.Models
{
    public class SchoolsModel : Schools
    {
        public SchoolsModel()
        {
            List = new List<Schools>();
        }
        public List<Schools> List { get; set; }
    }
}
