using System;

namespace kalodile.Domain
{
    public abstract class Entity
    {
        public string Id { get; protected set; }
        public DateTime CreatedOn { get; protected set; }

        protected string GenerateId() => Guid.NewGuid().ToString();
    }
}
