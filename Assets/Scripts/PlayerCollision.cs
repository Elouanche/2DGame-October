using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private HealthPlayer healthPlayer;
    private PlayerDie playerDie;

    void Start()
    {
        healthPlayer = GetComponent<HealthPlayer>();
        playerDie = GetComponent<PlayerDie>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Spike"))
        {
            healthPlayer.TakeDamage(100);
            playerDie.Die();
        }
    }
}
