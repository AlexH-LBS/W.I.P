using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    KeyCode input;
    public bool touching;
    public bool interaction;
    public int score;
    public Popularity Popularity;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(input) && touching )
        {
            StartCoroutine(InteractedAtMoment());
        }
        if (Input.GetKeyDown(input) && !touching)
        {
            print("missed");
        }
    }
    IEnumerator InteractedAtMoment()
    {
        interaction = true;
        yield return new WaitForSecondsRealtime(0.05f);
        interaction = false;
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        touching = true;
        if (interaction){
            score += 1;
            print("YOU SCORE");
            Popularity.fame(1);
            Destroy(collision.gameObject);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        touching= false;
    }
}
