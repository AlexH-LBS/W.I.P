using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineTesting2 : MonoBehaviour
{
    [SerializeField] private Transform[] points;
    [SerializeField] private Lines line;

    private void Start()
    {
        line.SetUpLine(points);
    }
}
