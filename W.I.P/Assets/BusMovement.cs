using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class BusMovement : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody2D bus;
    void Start()
    {
        bus = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //bus.velocity = bus.velocity.normalized;
        
        //temporary movement code
        if (Input.GetKey(KeyCode.W))
        {
            bus.velocity += new Vector2(0, 0.01f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            bus.velocity += new Vector2(0, -0.01f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            bus.velocity += new Vector2(-0.01f,0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            bus.velocity += new Vector2(0.01f,0);
        }

        if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.D))
        {
            bus.velocity = new Vector2(0, 0);
        }
        
    }
}
