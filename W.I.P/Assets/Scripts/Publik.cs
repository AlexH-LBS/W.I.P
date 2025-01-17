using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Publik : MonoBehaviour
{
    public Popularity popularity;
    public float speed;
    Rigidbody2D myRigidbody;
    public Transform[] points;
    public int witchOne;
    public bool movingToTarget = false;
    public void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        speed = popularity.GetComponent<Popularity>().crowdSpeed / 10;
        if(transform.position != points[witchOne].position)
        {
            movingToTarget = true;
        }
        if (transform.position == points[witchOne].position)
        {
            movingToTarget = false;
        }
        if (movingToTarget)
        {
            transform.position = Vector3.MoveTowards(transform.position, points[witchOne].position, speed * Time.deltaTime);
        }
        if(!movingToTarget)
        {
            if(witchOne == 0)
            {
                witchOne = 1;
            }
            if (witchOne == 1)
            {
                witchOne = 0;
            }
        }
    }
}
