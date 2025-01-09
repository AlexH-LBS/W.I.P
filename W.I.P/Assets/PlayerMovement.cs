using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody2D Player;
    public float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Player.velocity = new Vector2(0, movementSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Player.velocity = new Vector2(0, -movementSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Player.velocity = new Vector2(-movementSpeed, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Player.velocity = new Vector2(movementSpeed, 0);
        }

        if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.D))
        {
            Player.velocity = new Vector2(0, 0);
        }
    }
}
