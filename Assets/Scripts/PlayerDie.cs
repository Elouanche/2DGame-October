using UnityEngine;

public class PlayerDie : MonoBehaviour
{
    public void Die()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector3.up * 300);
        GetComponent<Collider2D>().isTrigger = true;
    }
}
