using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poster : MonoBehaviour
{
    [SerializeField] public Transform[] points;

    void Start()
    {
        this.points = points;
    }

}
