using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playmusc : MonoBehaviour
{
    public float timer;
    public AudioSource Playing;
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            Playing.Play();
        }
    }
}
