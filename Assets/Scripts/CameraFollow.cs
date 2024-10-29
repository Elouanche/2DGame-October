using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    public float timeOffset;
    public Vector3 posOffset;

    private Vector3 velocity;
    private PlayerDie playerDie;

    void Start()
    {
        playerDie = player.GetComponent<PlayerDie>();
    }

    void Update()
    {
        if (playerDie == null || playerDie.isDead)
        {
            return; 
        }

        transform.position = Vector3.SmoothDamp(transform.position, player.transform.position + posOffset, ref velocity, timeOffset);
    }
}
