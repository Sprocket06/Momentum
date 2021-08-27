using System.Collections.Generic;

namespace Momentum
{
    class CollisionManager
    {
        public static CollisionManager Instance;
        public List<Collider> Colliders;

        static CollisionManager()
        {
            Instance = new CollisionManager();
        }
        public CollisionManager()
        {
            Colliders = new List<Collider>();
        }

        public void Register(Collider c)
        {
            Colliders.Add(c);
        }
        
    }
}
