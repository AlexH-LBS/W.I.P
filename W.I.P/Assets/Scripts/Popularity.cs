using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popularity : MonoBehaviour
{
    public float fameInt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void fame(float HitMusic)
    {
        HitMusic *= 1.01f;
        fameInt += HitMusic;
    }
}
