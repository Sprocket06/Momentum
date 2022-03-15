namespace Momentum;

public class CollisionManager
{
    public List<ICollisionEntity> Entities;

    public void Register(ICollisionEntity e) => Entities.Add(e);

    public void ProcessMovement(ICollisionEntity entity)
    {
        foreach (ICollisionEntity other in Entities)
        {
            if (entity.Collider.CollidesWith(other.Collider))
            {
                entity.OnCollision(other);
                other.OnCollision(entity);
            }
        }
    }
}