using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.04f; //Field
    

    void Update()
    {
        float jumpForce = 200;
        if (Input.GetButtonDown("Jump") && isTouchingGround())
        {
            Rigidbody rigidBody = gameObject.GetComponent<Rigidbody>();
            rigidBody.AddForce(0, jumpForce, 0);
            rigidBody.angularVelocity = new Vector3(2, 0, 0);
        }
        transform.Translate(0, 0, speed, Space.World);
    }

    bool isTouchingGround()
    {
        int layerMask = LayerMask.GetMask("Ground");
        return Physics.CheckBox(transform.position, transform.lossyScale / 1.99f, transform.rotation, layerMask);
    }
}
