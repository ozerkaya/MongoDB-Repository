using MongoRL.Poco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoRL.Interfaces
{
    public interface IStudentDAL : IRepository<Students, string>
    {
    }

    public interface ISchoolsDAL : IRepository<Schools, string>
    {
    }
}
