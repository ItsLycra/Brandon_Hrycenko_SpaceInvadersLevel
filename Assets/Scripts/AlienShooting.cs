
using UnityEngine;
using System.Collections;

public class AlienShooting : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float minimumFireInterval = 2.5f;
    public float maximumFireInterval = 5f;

    void Start()
    {
        StartCoroutine(ShootRepeatedly());
    }

    IEnumerator ShootRepeatedly()
    {
        while (true)
        {
            float waitTime = Random.Range(minimumFireInterval,maximumFireInterval);

            yield return new WaitForSeconds(waitTime);

            if (projectilePrefab != null)
            {
                Vector3 spawnPosition = transform.position + Vector3.down * 0.5f;
                Instantiate(projectilePrefab, spawnPosition, Quaternion.identity);
            }
        }
    }
}
