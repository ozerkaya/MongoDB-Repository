using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoRL.Interfaces
{
    public interface IEntity
    {
    }
    public interface IEntity<out TKey> : IEntity where TKey : IEquatable<TKey>
    {
        public TKey Id { get; }
        DateTime CreatedAt { get; set; }
    }
}
