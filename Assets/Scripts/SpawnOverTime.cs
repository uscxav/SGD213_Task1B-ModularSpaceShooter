using UnityEngine;
using System.Collections;

public class SpawnOverTime : MonoBehaviour
{
    [SerializeField]
    private GameObject spawnObject;
    [SerializeField]
    private float spawnDelay = 2f;
    private Renderer ourRenderer;

    void Start()
    {
        // get ourRenderer, make invisible.
        ourRenderer = GetComponent<Renderer>();
        ourRenderer.enabled = false;
        // continously spawn game object with delay
        InvokeRepeating("Spawn", spawnDelay, spawnDelay);
    }

    void Spawn()
    {
        // create boundaries for the area the game object can spawn within
        float x1 = transform.position.x - ourRenderer.bounds.size.x / 2;
        float x2 = transform.position.x + ourRenderer.bounds.size.x / 2;
        // Randomly pick a point within the spawn object and spawn game object
        Vector2 spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);
        Instantiate(spawnObject, spawnPoint, Quaternion.identity);
    }
}
