using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleMusicBlock : MonoBehaviour
{
    public int speed = 4;
    Rigidbody2D myRigidbody;
    public GameObject spawnObject;
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myRigidbody.velocity = new Vector2(0, -speed);

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        Instantiate(spawnObject, transform.position, Quaternion.identity);
    }


}