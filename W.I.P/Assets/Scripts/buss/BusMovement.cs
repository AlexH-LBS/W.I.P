using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class BusMovement : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody2D bus;
    public float Speed;
    public bool move;
    
    
    
    void Start()
    {
        bus = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (move)
        {
            if (Input.GetKey(KeyCode.W))
            {
                bus.velocity += new Vector2(0, Speed);
            }
            if (Input.GetKey(KeyCode.S))
            {
                bus.velocity += new Vector2(0, -Speed);
            }
            if (Input.GetKey(KeyCode.A))
            {
                bus.velocity += new Vector2(-Speed, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                bus.velocity += new Vector2(Speed, 0);
            }

            if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
            {
                bus.velocity = new Vector2(0, 0);
            }
            else
            {
                bus.velocity = bus.velocity.normalized * Speed;
            }
        }



    }

   
}
