using Microsoft.Extensions.Options;
using MongoRL.Interfaces;
using MongoRL.Poco;
using MongoRL.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoRL.Repo
{
    public class StudentDAL : MongoDbRepositoryBase<Students>, IStudentDAL
    {
        public StudentDAL(IOptions<MongoDbSettings> options) : base(options)
        {
        }
    }

    public class SchoolsDAL : MongoDbRepositoryBase<Schools>, ISchoolsDAL
    {
        public SchoolsDAL(IOptions<MongoDbSettings> options) : base(options)
        {
        }
    }
}
