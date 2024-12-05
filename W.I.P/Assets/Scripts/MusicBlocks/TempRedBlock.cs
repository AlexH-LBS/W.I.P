using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempRedBlock : MonoBehaviour
{
    public float timer = 0.4f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0 ){
            Destroy(gameObject);
        }
    }
}
