using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.04f; //Field
    
    
    void Start()
    {
        
    }

    void Update()
    {
        Input isKeyWasJustPressed = Input.GetKeyDown(KeyCode.Space);
        if (...)
        {
            
        }
        Rigidbody rb = GetComponent<Rigidbody>();
        
        transform.Translate(0, 0, speed);
    }
}
