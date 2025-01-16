using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endDialog : MonoBehaviour
{
    public static endDialog instance;
    public GameObject prepdia;
    public GameObject popdia;
    public GameObject polydia;
    public GameObject offScreenDeathDialogue;
    void Start()
    {
        popdia.SetActive(false);
        prepdia.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void compare(int pop, int prep)
    {
        if(pop != 0 && prep != 0)
        {
            if(pop > prep)
            {
                popdia.SetActive(true);
            }
            if(prep > pop)
            {
                prepdia.SetActive(true);
            }
        }
    }
}
