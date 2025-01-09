using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class BusMovement : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody2D bus;
    public float maxSpeed;
    float currentMovementSpeed;
    
    
    void Start()
    {
        bus = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        bus.velocity = transform.up*currentMovementSpeed;
        
        
        if (Input.GetKey(KeyCode.W))
        {
            currentMovementSpeed = maxSpeed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            currentMovementSpeed = -maxSpeed;
        }
        else
        {
            currentMovementSpeed = 0;
        }
        if (Input.GetKey(KeyCode.A)&&currentMovementSpeed!=0)
        {
            transform.Rotate(0, 0, 0.5f);
        }
        if (Input.GetKey(KeyCode.D) && currentMovementSpeed != 0)
        {
            transform.Rotate(0, 0, -0.5f);
        }

        
        
    }

   
}
