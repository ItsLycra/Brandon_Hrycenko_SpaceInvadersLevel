using UnityEngine;
using System.Collections;
public class PlayerHit : MonoBehaviour
{
    private bool invulnerable = false;
    private Collider2D playerCollider;
    private PlayerShooting playerShooting;

    void Awake()
    {
        playerCollider = GetComponent<Collider2D>();
        playerShooting = GetComponent<PlayerShooting>();
    }

    public void TakeHit()
    {
        if(!invulnerable)
        {
            StartCoroutine(InvulerabilityPeriod());
        }
    }
    IEnumerator InvulerabilityPeriod()
    {
        invulnerable = true;
        playerCollider.enabled = false;
        playerShooting.enabled = false;

        yield return new WaitForSeconds(.5f);

        playerCollider.enabled = true;
        invulnerable = false;
        playerShooting.enabled = true;
    }
}

