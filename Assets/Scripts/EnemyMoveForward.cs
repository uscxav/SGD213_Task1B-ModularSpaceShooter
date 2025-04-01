using UnityEngine;
using System.Collections;

public class EnemyMoveForward : MonoBehaviour {

    private float acceleration = 75f;
    private float initialVelocity = 2f;
    private Rigidbody2D ourRigidbody;

   
    void Start()
    {
        // apply initialVelocity to rigidbody
        ourRigidbody = GetComponent<Rigidbody2D>();
        ourRigidbody.velocity = Vector2.down * initialVelocity;
    }

   
    void Update()
    {
        // add force using acceleration
        Vector2 ForceToAdd = Vector2.down * acceleration * Time.deltaTime;
        ourRigidbody.AddForce(ForceToAdd);
    }
}
