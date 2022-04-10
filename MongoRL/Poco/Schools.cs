using MongoRL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoRL.Poco
{
    public class Schools : MongoDbEntity
    {
        public string Name { get; set; }
        public string City { get; set; }
    }
}
