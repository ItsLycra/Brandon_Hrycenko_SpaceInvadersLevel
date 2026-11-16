
using UnityEngine;
using System.Collections;

public class AlienFormation : MonoBehaviour
{
    public GameObject alienPrefab;
    public GameObject alien2Prefab;

    public Transform greenAlienGroup;
    public Transform pinkAlienGroup;

    public int columns = 8;
    public float horizontalSpacing = 1.2f;
    public float verticalSpacing = 0.8f;

    void Start()
    {
        StartCoroutine(SpawnAliens());
    }

    IEnumerator SpawnAliens()
    {
      
        for (int row = 0; row < 2; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                Vector3 spawnPosition = new Vector3(-4.2f + column * horizontalSpacing,1.5f - row * verticalSpacing,0f);

                Instantiate(alienPrefab, spawnPosition, alienPrefab.transform.rotation, greenAlienGroup);
            }
        }

      
        yield return new WaitForSeconds(3f);

        
       for (int row = 0; row < 4; row++)
{
    int aliensInRow = 7 - (2 * row);

    for (int column = 0; column < aliensInRow; column++)
    {
        float startX = -(aliensInRow - 1) * horizontalSpacing / 2f;

        Vector3 spawnPosition = new Vector3(startX + column * horizontalSpacing,3.5f - row * verticalSpacing,0f);

        Instantiate(alien2Prefab, spawnPosition,alien2Prefab.transform.rotation, pinkAlienGroup);
            }
        }
    }
}
