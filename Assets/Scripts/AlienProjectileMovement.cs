
using UnityEngine;

public class AlienProjectileMovement : MonoBehaviour
{
    public float projectileSpeed = 5f;
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        rb.gravityScale = 0f;
        rb.freezeRotation = true;
        rb.linearVelocity = Vector2.down * projectileSpeed;
    }

    void Update()
    {
        if (transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Barrier"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerHit>().TakeHit();
            Destroy(gameObject);
        }
    }
}
