using UnityEngine;
using System.Collections;
public class PlayerHit : MonoBehaviour
{
    private bool invulnerable = false;
    private Collider2D playerCollider;
    private PlayerShooting playerShooting;
    private SpriteRenderer playerSprite;

    void Awake()
    {
        playerCollider = GetComponent<Collider2D>();
        playerShooting = GetComponent<PlayerShooting>();
        playerSprite = GetComponent<SpriteRenderer>();
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

        float elapsed = 0f;

        while (elapsed < .5f)
        {
            playerSprite.enabled = false;
            yield return new WaitForSeconds(.1f);
            playerSprite.enabled = true;
            yield return new WaitForSeconds(.1f);
            elapsed += .2f;
        }

        yield return new WaitForSeconds(.5f);

        playerCollider.enabled = true;
        invulnerable = false;
        playerShooting.enabled = true;
        playerSprite.enabled = true;
    }
}

