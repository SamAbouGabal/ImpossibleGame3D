using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.04f; //Field
    
    
    
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(0, 0, speed);
        bool whenKeyIsPressed = Input.GetKeyDown(KeyCode.Space);
        if (whenKeyIsPressed)
        {
            Rigidbody rigidBody = GetComponent<Rigidbody>();
            rigidBody.AddForce(0, 300, 0);
        }
        
    }
}
