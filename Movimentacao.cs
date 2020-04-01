using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            rb.AddForce(0,0,30);        
        if (Input.GetKey(KeyCode.S))
            rb.AddForce(0,0,-30);        
        if (Input.GetKey(KeyCode.A))
            rb.AddForce(-30,0,0);
        if (Input.GetKey(KeyCode.D))
            rb.AddForce(30, 0, 0);
    }
}
