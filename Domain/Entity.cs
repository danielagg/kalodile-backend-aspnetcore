using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kalodile.Domain
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }
        public DateTime CreatedOn { get; protected set; }
    }
}
