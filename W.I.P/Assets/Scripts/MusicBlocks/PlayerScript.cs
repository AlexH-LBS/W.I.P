using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    KeyCode input;

    public int score;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(input))
        {
            score += 1;
        }
    }
}
