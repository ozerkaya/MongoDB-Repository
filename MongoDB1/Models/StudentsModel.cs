using MongoRL.Poco;

namespace MongoDB1.Models
{
    public class StudentsModel: Students
    {
        public StudentsModel()
        {
            List = new List<Students>();
        }
        public List<Students> List { get; set; }
    }
}
