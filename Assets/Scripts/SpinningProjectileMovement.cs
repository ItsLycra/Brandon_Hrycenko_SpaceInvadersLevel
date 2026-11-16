using UnityEngine;

public class SpinningProjectileMovement : MonoBehaviour
{
    public float projectileSpeed = 10f;
    public float rotationSpeed = 500f;

    void Update()
    {
        transform.position += Vector3.up * projectileSpeed * Time.deltaTime;

        transform.Rotate(0f,0f,rotationSpeed * Time.deltaTime);

        if (transform.position.y > 6f)
        {
            Destroy(gameObject);
        }
    }

}
