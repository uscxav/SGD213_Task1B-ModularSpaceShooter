using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour
{

    [SerializeField]
    private GameObject bullet;
    private float lastFiredTime = 0f;
    [SerializeField]
    private float fireDelay = 1f;
    private float bulletOffset = 2f;

    void Start()
    {
        // Spawns the bullet at a set distance in front of the player
        bulletOffset = GetComponent<Renderer>().bounds.size.y / 2 + bullet.GetComponent<Renderer>().bounds.size.y / 2; 
    }

    
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            float CurrentTime = Time.time;
            // Time delay between bullets fired
            if (CurrentTime - lastFiredTime > fireDelay)
            {
                Vector2 spawnPosition = new Vector2(transform.position.x, transform.position.y + bulletOffset);
                Instantiate(bullet, spawnPosition, transform.rotation);
                lastFiredTime = CurrentTime;
            }
        }
    }
}
