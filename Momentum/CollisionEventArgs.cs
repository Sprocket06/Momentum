using System;
using System.Collections.Generic;

namespace Momentum
{
    class CollisionEventArgs : EventArgs
    {
        public List<Collision> collisions;
        public CollisionEventArgs(List<Collision> c)
        {
            collisions = c;
        }
    }
}
