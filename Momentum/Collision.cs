namespace Momentum
{
    struct Collision
    {
        public Collision(Collider c, Manifold m)
        {
            this.collider = c;
            this.collisionInfo = m;
        }
        public Collider collider;
        public Manifold collisionInfo;
    }
}
