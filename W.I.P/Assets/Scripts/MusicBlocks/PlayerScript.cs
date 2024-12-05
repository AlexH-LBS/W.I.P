using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    //custom input field 
    [SerializeField]
    KeyCode input;
    //true or false
    public bool touching;
    public bool interaction;
    //score duh
    public int score;
    //to tell the popularity script hit
    public Popularity Popularity;
    //debug menu shit
    public TextMeshProUGUI text;
    public TextMeshProUGUI lastMove;

    void Update()
    {
        //if player hit while touching make it do some shit
        if (Input.GetKeyDown(input) && touching )
        {
            StartCoroutine(InteractedAtMoment());
        }
        //if player pressed when not touching it say miss
        if (Input.GetKeyDown(input) && !touching)
        {
            print("missed");
            lastMove.text = "Miss";
        }
    }
    //not really sure found it on google as an solution
    IEnumerator InteractedAtMoment()
    {
        interaction = true;
        yield return new WaitForSecondsRealtime(0.05f);
        interaction = false;
    }
    //update loop but only when touching block
    public void OnTriggerStay2D(Collider2D collision)
    {
        //the thing that destroys the block and adds scores
        touching = true;
        if (interaction){
            score += 1;
            print("YOU SCORE");
            Popularity.fame(1);
            text.text = score.ToString();
            Destroy(collision.gameObject);
            lastMove.text = "Hit";
        }
    }
    //when collsion ends touching ends
    private void OnTriggerExit2D(Collider2D collision)
    {
        touching= false;
    }
}
