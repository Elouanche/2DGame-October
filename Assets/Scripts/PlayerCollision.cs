using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private HealthPlayer healthPlayer;
    private PlayerDie playerDie;
    private Rigidbody2D rb;

    void Start()
    {
        healthPlayer = GetComponent<HealthPlayer>();
        playerDie = GetComponent<PlayerDie>();
        rb = GetComponent<Rigidbody2D>(); 
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Spike"))
        {
            healthPlayer.TakeDamage(100);
            CheckPlayerDeath();
        }

        if (collision.CompareTag("Saw"))
        {
            healthPlayer.TakeDamage(50);
            ApplyKnockback(collision);
            CheckPlayerDeath();
        }
    }

    private void ApplyKnockback(Collider2D collision)
    {
        Vector2 knockbackDirection = (transform.position - collision.transform.position).normalized;
        rb.AddForce(knockbackDirection * 20f, ForceMode2D.Impulse);
    }

    private void CheckPlayerDeath()
    {
        if (healthPlayer.currentHealth <= 0)
        {
            playerDie.Die();
        }
    }
}
