using UnityEngine;

public class AlienProjectileMovement : MonoBehaviour
{
    public float projectileSpeed =5f;

    void Update()
    {
        transform.position += Vector3.down *projectileSpeed *Time.deltaTime;

        if (transform.position.y <-6f)
        {
            Destroy(gameObject);
        }
        
    }
}
