using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popularity : MonoBehaviour
{
    public float fameInt;
    public float crowdSpeed = 0.0f;
    public float increase = 1.01f;

    // Start is called before the first frame update
    void Start()
    {
        if (fameInt == 0)
        {
            crowdSpeed = 0;
        }

    }

    // Update is called once per frame
    void Update()
    {
       

    }

    public void fame(float HitMusic, float missedMusic)
    {
        fameInt += HitMusic;
        fameInt *= 1.01f;
        crowdSpeed = fameInt;

        if (fameInt >= 1.0f && fameInt <= 2.0f)
        {
            crowdSpeed += 1;
            print(crowdSpeed);
        }
        else if (fameInt >= 3.0f && fameInt <= 1000.0f)
        {
            crowdSpeed *= increase;
            print(crowdSpeed);
        }


    }
}