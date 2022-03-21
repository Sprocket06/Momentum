using System;

namespace Momentum;

public class CircleCollider : Collider
{
    public float Radius;

    public CircleCollider(Vector2 pos, float r)
    {
        this.Radius = r;
        this.Position = pos;
    }
    
    public override bool CollidesWith(Collider other)
    {
        switch (other)
        {
            case RectangleCollider r:
            {
                var rect = new cute_c2.c2AABB(r.Position, r.Position + r.Size);
                var circle = new cute_c2.c2Circle(this.Position, this.Radius);

                return c2CircletoAABB(circle, rect);
            }
            case CircleCollider c:
            {
                var circleA = new cute_c2.c2Circle(this.Position, this.Radius);
                var circleB = new cute_c2.c2Circle(c.Position, c.Radius);

                return c2CircletoCircle(circleA, circleB);
            }
            default:
                return false;
        }
    }

    public override CollisionData GetCollisionData(Collider other)
    {
        c2Manifold manifold = new();
        switch (other)
        {
            case RectangleCollider r:
            {
                var rect = new c2AABB(r.Position, r.Position + r.Size);
                var circle = new c2Circle(this.Position, this.Radius);
                
                c2CircletoAABBManifold(circle, rect, ref manifold);
                return new(manifold);
            }
            case CircleCollider c:
            {
                var circleA = new c2Circle(this.Position, this.Radius);
                var circleB = new c2Circle(c.Position, c.Radius);
                
                c2CircletoCircleManifold(circleA, circleB, ref manifold);
                return new(manifold);
            }
            default:
                throw new UnsupportedColliderException();
        }
    }
}