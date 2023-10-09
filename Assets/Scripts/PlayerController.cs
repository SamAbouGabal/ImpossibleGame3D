using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.04f; //Field
    
    
    
    private void Update()
    {
        float jumpForce = 200;
        if (Input.GetButtonDown("Jump") && isTouchingGround())
        {
            Rigidbody rigidBody = gameObject.GetComponent<Rigidbody>();
            rigidBody.AddForce(0, jumpForce, 0);
            rigidBody.angularVelocity = new Vector3(2, 0, 0);
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