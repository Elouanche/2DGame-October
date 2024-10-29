using UnityEngine;

public class PlayerSpawnPoint : MonoBehaviour
{
    public void Awake()
    {
        GameObject.FindGameObjectWithTag("Player").transform.position = transform.position;
    }
}
