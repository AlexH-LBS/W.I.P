using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallBlockSpawner : MonoBehaviour
{
    //inital timer
    public bool active = false;
    //the music block thats being spawned
    public GameObject Spawning;
    //Beats per min and beats per second
    //only BPM can be changed, BPS is determined in the code
    public float BPM;
    public float BPS;
    //timer variables
    public float initalTimer = 3;
    public float timer;
    //resets timer at start tho make the code simpler and reusable
    void Start(){
        resetTimer();
    }
    //resets the timer
    void resetTimer(){
        BPS = BPM / 60;
        timer = 1 / BPS;
    }

    void Update(){
        //timers
        initalTimer -= Time.deltaTime;
        timer -= Time.deltaTime;
        //makes it spawn stuff after inital timer
        if(initalTimer < 0){
            active = true;
        }
        //spawning code 
        if (timer < 0 && active){
            Instantiate(Spawning, gameObject.transform.position, Quaternion.identity);   
            resetTimer();
        }
    }
}
