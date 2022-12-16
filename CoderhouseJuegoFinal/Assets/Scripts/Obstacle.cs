using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] Transform positionExplosion;
    [SerializeField] Vector3 initialPos;
    
    void Start()
    {
        initialPos = gameObject.transform.localPosition;
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
