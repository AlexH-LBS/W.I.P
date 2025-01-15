using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Playmusc : MonoBehaviour
{
    public float timer;
    public AudioSource Playing;
    public void Start()
    {
        StartCoroutine(playmucis());
    }

    IEnumerator playmucis()
    {
        yield return new WaitForSecondsRealtime(timer);
        Playing.Play();
    }
}
