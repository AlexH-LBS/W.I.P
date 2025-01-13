using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.UIElements;

public class SingleMusicBlock : MonoBehaviour
{
    public int speed = 4;
    Rigidbody2D myRigidbody;
    public Popularity popularity;
    void Start(){
        myRigidbody = GetComponent<Rigidbody2D>();
        myRigidbody.velocity = new Vector2(0, -speed);
    }
    private void OnTriggerExit2D(Collider2D collision){
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.name == "StringSprite1")
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
        }
        if (collision.gameObject.name == "StringSprite2")
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(255, 200, 0);
        }
        if (collision.gameObject.name == "StringSprite3")
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(0, 255, 0);
        }
        if (collision.gameObject.name == "StringSprite4")
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(0, 200, 255);
        }
    }

    private void OnDestroy(){

    }


}
