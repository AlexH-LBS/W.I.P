using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float[] TimeInBetween;

    public float timer;
    public int witchOne = 0;
    public GameObject Spawning;
    public float BPM;
    public float BPS;
    //resets timer at start tho make the code simpler and reusable
    void Start()
    {
        BPS = ((int)TimeInBetween[witchOne]);
        BPS = BPM / 60;
        timer = 1 / BPS;
    }


    void Update()
    {
        timer -= Time.deltaTime;
        if(timer < 0)
        {
            BPS = ((int)TimeInBetween[witchOne]);
            BPS = BPM / 60;
            timer = 1 / BPS;
            witchOne += 1;
            Instantiate(Spawning, gameObject.transform.position, Quaternion.identity);
        }
    }
}
