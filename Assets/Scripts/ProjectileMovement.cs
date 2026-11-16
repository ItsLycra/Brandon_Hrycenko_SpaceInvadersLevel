using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    public float projectileSpeed = 10f;

    void Update()
    {
        transform.position += Vector3.up * projectileSpeed * Time.deltaTime;

        if(transform.position.y > 6f)
        {
            Destroy(gameObject);
        }


    }

}
