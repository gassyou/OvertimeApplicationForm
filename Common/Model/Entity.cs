using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Model
{
    public abstract class Entity<TId>
    {
        public TId Id { get; protected set; }
        public int Version { get; protected set; }
    }
}
