using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Playmusc : MonoBehaviour
{
    public int speed = 4;
    Rigidbody2D myRigidbody;
    public AudioSource Playing;
    public void Start()
    {
        Playing.Play();   
        myRigidbody = GetComponent<Rigidbody2D>();
        myRigidbody.velocity = new Vector2(0, -speed);
        Playing.Pause();
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Playing.Play();
        Destroy(gameObject);
    }
}
