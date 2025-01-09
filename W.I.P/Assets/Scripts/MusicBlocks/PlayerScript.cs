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
    public bool longBlock;
    public bool longBlockScore;
    //score duh
    public int score;
    //error time for long
    public float errorTimeForLong = 0.25f;
    //to tell the popularity script hit
    public Popularity Popularity;
    //debug menu shit
    public TextMeshProUGUI text;
    public TextMeshProUGUI lastMove;

    void Update()
    {
        //if player hit while touching make it do some shit
        if (Input.GetKey(input) && touching)
        {
            if (longBlock)
            {
                interaction = true;
            }
            else
            {
                StartCoroutine(InteractedAtMoment());
            }
        }
        if (Input.GetKeyUp(input)) {
            StartCoroutine(InteractedAtMoment());
        }
        //if player pressed when not touching it say miss
        if (Input.GetKeyDown(input) && !touching)
        {
            print("missed " + gameObject.name);
            lastMove.text = "Miss";
            Popularity.fame(-1, 0);
        }
    }
    //sets interaction to true then false after .05 seconds
    IEnumerator InteractedAtMoment()
    {
        interaction = true;
        longBlockScore = true;
        yield return new WaitForSecondsRealtime(0.05f);
        interaction = false;
        longBlockScore = false;

    }
    IEnumerator LongBlockInteraction(Collider2D collision)
    {
        //wait .25 seconds before cheaking if interaction is still not happening(error time)
        yield return new WaitForSecondsRealtime(errorTimeForLong);

        if (!interaction)
        {
            //incase the long block dosent delete it self
            if(collision != null){
                Destroy(collision.gameObject);
            }
            longBlockScore = false;
            lastMove.text = "Missed Long";
        }
        if (interaction){
            longBlockScore = true;
        }
    }
    //update loop but only when touching block
    public void OnTriggerStay2D(Collider2D collision)
        {
            //the thing that destroys the block and adds scores
            touching = true;
            //cheakcs if its long 
            if (collision.gameObject.tag == "LongMusicBlock")
            {
                longBlock = true;
            }
            if (interaction && longBlock) {
                lastMove.text = "Hiting Long";
            }
            //if you miss the long block 
            if (!interaction && longBlock) {
                StartCoroutine(LongBlockInteraction(collision));

            }
            //score thingy
            if (interaction && !longBlock) {
                score += 1;
                print("YOU SCORE");
                //I added so that the hitmusic is mulitplied by 1%, probably doesnt work but you get roughly the point. is it possible to make the score and fame/hitmusic the same so we write less code and variables?
                Popularity.fame(1, 0);
                text.text = score.ToString();
                Destroy(collision.gameObject);
                lastMove.text = "Hit";
            }
        }
        //when collsion ends touching ends
        private void OnTriggerExit2D(Collider2D collision)
        {

        //score long block
        if (interaction && longBlockScore && longBlock){
            score += 2;
            print("YOU SCORE LONG");
            Popularity.fame(2, 0);
            text.text = score.ToString();
            longBlockScore = false;
        }
        touching = false;
        longBlock = false;
        }


    
}
