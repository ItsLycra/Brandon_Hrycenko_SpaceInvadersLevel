using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    public GameObject projectilePrefab;
    public GameObject spinningProjectilePrefab;

    void Update()
    {
        if (Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Vector3 spawnPosition = transform.position + new Vector3(0f,0.6f,0f);

            Instantiate(projectilePrefab,spawnPosition,Quaternion.identity);
        }
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            Vector3 spawnPosition = transform.position + new Vector3(0f,0.6f,0f);

            Instantiate(spinningProjectilePrefab,spawnPosition,Quaternion.identity);
        }
    }

}
