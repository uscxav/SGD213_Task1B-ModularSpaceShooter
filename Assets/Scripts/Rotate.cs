using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour
{
    [SerializeField]
    private float maxSpinSpeed = 200;

    void Start()
    {
        // randomise spin speed of meteor between 0 and the maxSpinSpeed
        GetComponent<Rigidbody2D>().angularVelocity = Random.Range(-maxSpinSpeed, maxSpinSpeed);
    }
}
