using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.04f;
    
    
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(0, 0, speed);
    }
}
