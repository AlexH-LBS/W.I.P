using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedPoster : MonoBehaviour
{
    //inputs
    [SerializeField] KeyCode up = KeyCode.W;
    [SerializeField] KeyCode down = KeyCode.S;
    [SerializeField] KeyCode back = KeyCode.A;
    [SerializeField] KeyCode forword = KeyCode.D;
    //pos
    [SerializeField] private Transform[] points;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(up))
        {
            gameObject.transform.position = points[0].position;
        }
        if (Input.GetKeyDown(down))
        {
            gameObject.transform.position = points[1].position;
        }
        if (Input.GetKeyDown(back))
        {
            gameObject.transform.position = points[2].position;
        }
        if (Input.GetKeyDown(forword))
        {
            gameObject.transform.position = points[3].position;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        points = collision.gameObject.GetComponent<Poster>().points;
    }
}
