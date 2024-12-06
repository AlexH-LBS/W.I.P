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
        int choice=Dialogue("Helllo", "hi", "Greetings", "eh");
        print(choice);
    }

    int Dialogue(string Statement, string Answer0, string Answer1, string Answer2)
    {
        return 1;
        //WaitUntil choiceMade = true;
        
    }
}
