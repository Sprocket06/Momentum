namespace Momentum;

public interface ICollisionEntity
{
    public Collider Collider { get; set; }

    public void OnCollision(ICollisionEntity other);
}