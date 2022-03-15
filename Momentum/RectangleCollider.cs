namespace Momentum;

public class RectangleCollider : Collider
{
    public Vector2 Size;

    public RectangleCollider(Vector2 pos, Vector2 size)
    {
        this.Position = pos;
        this.Size = size;
    }

    public override bool CollidesWith(Collider other)
    {
        switch (other)
        {
            case RectangleCollider r:
            {
                var rectA = new cute_c2.c2AABB(this.Position, this.Position+this.Size);
                var rectB = new cute_c2.c2AABB(r.Position, r.Position + r.Size);

                return c2AABBtoAABB(rectA,rectB);
            }
            case CircleCollider c:
                var rect = new cute_c2.c2AABB(this.Position, this.Position + this.Size);
                var circle = new cute_c2.c2Circle(c.Position, c.Radius);

                return c2CircletoAABB(circle, rect);
            default:
                return false;
            
        }
    }
}