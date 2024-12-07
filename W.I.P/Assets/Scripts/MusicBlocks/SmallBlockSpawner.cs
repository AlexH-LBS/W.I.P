using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallBlockSpawner : MonoBehaviour
{
    public bool active;
    public GameObject Spawning;
    public float BPM;
    public float BPS;
    public float timer;
    void Start(){
        resetTimer();
    }
    void resetTimer(){
        BPS = BPM / 60;
        timer = 1 / BPS;
    }

    void Update(){
        timer -= Time.deltaTime;
        if (timer < 0 && active){
            Instantiate(Spawning, gameObject.transform.position, Quaternion.identity);   
            resetTimer();
        }
    }
}
