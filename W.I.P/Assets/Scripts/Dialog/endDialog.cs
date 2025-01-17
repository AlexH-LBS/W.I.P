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
        polydia.SetActive(false);
        offScreenDeathDialogue.SetActive(false );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void compare(int pop, int prep)
    {
        if(pop != 0 && prep != 0)
        {
            if(pop < 20 && prep < 20)
            {
                offScreenDeathDialogue.SetActive(true);
            }
            if(pop > prep)
            {
                popdia.SetActive(true);
                timer();
            }
            if(prep > pop)
            {
                prepdia.SetActive(true);
                timer();
            }
            if(prep == pop)
            {
                polydia.SetActive(true);
                timer();
            }
        }
    }
    IEnumerator timer()
    {
        yield return new WaitForSeconds(20);
        Application.Quit();
    }
}
