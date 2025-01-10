using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poster : MonoBehaviour
{
    [SerializeField] public Transform[] points;

    [SerializeField] public GameObject poster;
    void Start()
    {
        this.points = points;
        poster.SetActive(false);
    }

}
