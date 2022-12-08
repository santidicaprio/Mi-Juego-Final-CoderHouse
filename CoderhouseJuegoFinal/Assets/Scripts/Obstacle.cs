using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] Transform positionExplosion;
    
    void Start()
    {

    }


    void Update()
    {

    }

    public void DeactiveKinematic()
    {
        rb.isKinematic = false;
    }

    public void BreakWall()
    {
        rb.AddExplosionForce(30f, positionExplosion.position, 30f);
        
    }
}
