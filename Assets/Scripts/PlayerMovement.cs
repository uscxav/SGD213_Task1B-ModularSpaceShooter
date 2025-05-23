﻿using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float f_horPlayAccel = 5000f;
    private Rigidbody2D ourRigidbody;


    void Start() 
    {
        // store a reference to ourRigidBody component
        ourRigidbody = GetComponent<Rigidbody2D>(); 
    }
 
    void Update() 
    {
        // get HorizonalInput and applies force to it using f_horPlayAccel
        float HorizontalInput = Input.GetAxis("Horizontal");
        if (HorizontalInput != 0.0f) {
            Vector2 ForceToAdd=Vector2.right * HorizontalInput * f_horPlayAccel * Time.deltaTime;
            ourRigidbody.AddForce(ForceToAdd);
            
        }
    }
}
