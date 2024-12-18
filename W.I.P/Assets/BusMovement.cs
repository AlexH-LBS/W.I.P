using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class BusMovement : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody2D bus;
    new Vector3 movementSpeed;
    new Vector3 rotation;
    
    void Start()
    {
        bus = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        bus.velocity = bus.velocity.normalized;

        //bus.velocity = movementSpeed * rotation
        
        //temporary movement code
        if (Input.GetKey(KeyCode.W))
        {
            //bus.velocity = movementSpeed + (new Vector2(0, 1));
        }
        if (Input.GetKey(KeyCode.S))
        {
            bus.velocity = new Vector2(0, -1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, 1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -1);
        }

        if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.D))
        {
            bus.velocity = new Vector2(0, 0);
        }
        
    }

    private void Rotate()
    {

    }
}
