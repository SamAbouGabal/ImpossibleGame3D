using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.04f; //Field
    
    
    
    void Start()
    {
        
    }

    void Update()
    {
        float jumpForce = 200;
        if (Input.GetButtonDown("Jump"))
        {
            Rigidbody rigidBody = gameObject.GetComponent<Rigidbody>();
            rigidBody.AddForce(0, jumpForce, 0);
        }
        transform.Translate(0, 0, speed);
    }
}
