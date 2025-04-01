using UnityEngine;
using System.Collections;

public class BulletMoveForward : MonoBehaviour {

    private float acceleration = 50f;
    private float initialVelocity = 5f;
    private Rigidbody2D ourRigidbody;

    
    void Start()
    { 
        // apply initialVelocity to rigidbody
        ourRigidbody = GetComponent<Rigidbody2D>();
        ourRigidbody.velocity = Vector2.up * initialVelocity;
    }

   
    void Update()
    { 
        // add force using acceleration
        Vector2 ForceToAdd = Vector2.up * acceleration * Time.deltaTime;
        ourRigidbody.AddForce(ForceToAdd);
    }
}
