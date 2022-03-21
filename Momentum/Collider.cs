namespace Momentum;

public abstract class Collider
{
    public Vector2 Position;
    public abstract bool CollidesWith(Collider other);
    public abstract CollisionData GetCollisionData(Collider other);
}