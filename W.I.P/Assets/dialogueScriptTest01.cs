using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueScriptTest01 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("script start");
    }

    // Update is called once per frame
    void Update()
    {
        //string choice=Dialogue("hi", "Greetings", "eh");
        //print(choice);
    }

    //change from void to string later
    void Dialogue(string Answer0, string Answer1, string Answer2)
    {
        
        int choice=0;
        if (Input.GetKeyDown(KeyCode.W))
        {
            choice += 1;
            print(choice);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            choice -= 1;
            print(choice);
        }
        if (choice >= 3)
        {
            choice = 0;
            print(choice);
        }
        if (choice <= 0)
        {
            choice = 3;
            print(choice);
        }
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            if (choice == 0)
            {
                //return Answer0;
            }
            if (choice == 1)
            {
                //return Answer1;
            }
            if (choice == 0)
            {
                //return Answer2;
            }


            
        }
        
        
    }
}
