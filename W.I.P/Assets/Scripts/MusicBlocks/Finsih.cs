using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.UIElements;

public class finish : MonoBehaviour
{
    public int speed = 4;
    Rigidbody2D myRigidbody;
    public Popularity popularity;
    public int timer;
    void Start(){
        StartCoroutine(times());
    }
    IEnumerator times()
    {
        yield return new WaitForSeconds(timer);
        myRigidbody = GetComponent<Rigidbody2D>();
        myRigidbody.velocity = new Vector2(0, -speed);
    }
    private void OnTriggerExit2D(Collider2D collision){
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision){
        transform.position = new Vector3(collision.transform.position.x, transform.position.y);
    }

    private void OnDestroy(){

    }


}
