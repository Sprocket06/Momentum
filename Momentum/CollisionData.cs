namespace Momentum;

public class CollisionData
{
    internal CollisionData(c2Manifold manifold)
    {
        this.Normal = manifold.n;
        this.Count = manifold.count;
        this.ContactPoints = new Vector2[manifold.contact_points.Length];
        for (int i = 0; i < manifold.contact_points.Length; i++)
        {
            this.ContactPoints[i] = manifold.contact_points[i];
        }
        this.Depths = new float[manifold.depths.Length];
        for (int i = 0; i < manifold.depths.Length; i++)
        {
            this.Depths[i] = manifold.depths[i];
        }
    }
    public Vector2 Normal { get; set; }
    public Vector2[] ContactPoints;
    public float[] Depths;
    public int Count;
}