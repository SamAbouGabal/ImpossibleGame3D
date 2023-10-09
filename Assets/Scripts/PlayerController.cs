using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.04f; //Field
    
    
    
    private void Update()
    {
        float jumpForce = 200;
        float cubeSpin = 2;
        if (Input.GetButton("Jump") && isTouchingGround())
        {
            Rigidbody rigidBody = gameObject.GetComponent<Rigidbody>();
            Vector3 velocity = rigidBody.velocity;
            velocity.y = jumpForce;
            rigidBody.velocity = velocity;
            rigidBody.angularVelocity = new Vector3(cubeSpin, 0, 0);
        }

    }

    private void FixedUpdate()
    {
        Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();
        rigidbody.velocity = new Vector3(rigidbody.velocity.x, rigidbody.velocity.y, speed);
    }

    bool isTouchingGround()
    {
        int layerMask = LayerMask.GetMask("Ground");
        return Physics.CheckBox(transform.position, transform.lossyScale / 1.99f, transform.rotation, layerMask);
    }
}