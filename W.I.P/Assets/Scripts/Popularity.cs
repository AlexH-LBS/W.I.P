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

    public void fame(float HitMusic, float miss)
    {
        crowdSpeed = fameInt;
        fameInt += HitMusic;
        fameInt *= 1.01f;
        fameInt -= miss;

        if (fameInt < 0)
        {
            fameInt = 0;
            print("lower than 0");
        }
        if (fameInt >= 0.0f && fameInt <= 1000.0f)
        {
            crowdSpeed *= increase;
            print(crowdSpeed);
        }

        if(fameInt > 100)
        {
            fameInt = 99;
            crowdSpeed = 100;
        }

    }
}