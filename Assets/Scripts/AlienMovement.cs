
using UnityEngine;

public class AlienMovement : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float horizontalLimit = 7f;
    public float dropDistance = 0.5f;

    private int direction = 1;

    void Update()
    {
        transform.position += Vector3.right * direction * moveSpeed * Time.deltaTime;

        if (transform.position.x >= horizontalLimit && direction == 1)
        {
            direction = -1;
            MoveDown();
        }
        else if (transform.position.x <= -horizontalLimit && direction == -1)
        {
            direction = 1;
            MoveDown();
        }
    }

    void MoveDown()
    {
        transform.position += Vector3.down * dropDistance;
    }
}
