using UnityEngine;

public class PlayerDie : MonoBehaviour
{
    public bool isDead = false;
    private float deathThresholdY; 
    private Rigidbody2D rb;

    public void Die()
    {
        if (isDead) return; 
        isDead = true;

        GetComponent<ControllerPlayer>().enabled = false;

        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.zero; 
        rb.gravityScale = 1f; 
        rb.constraints = RigidbodyConstraints2D.FreezeRotation; 
        rb.AddForce(Vector2.up * 3, ForceMode2D.Impulse); 

        deathThresholdY = transform.position.y - 15f;

        Collider2D[] colliders = GetComponents<Collider2D>();
        foreach (Collider2D collider in colliders)
        {
            collider.enabled = false;
        }
    }

    void Update()
    {
        if (isDead && transform.position.y <= deathThresholdY)
        {
            Destroy(gameObject); 
        }
    }
}
