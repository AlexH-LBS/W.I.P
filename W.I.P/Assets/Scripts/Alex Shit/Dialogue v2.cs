using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialoguev2 : MonoBehaviour
{
    // Start is called before the first frame update
    int dialogueGeneration = 0;
    int dialoguePath = 0;
    void Start()
    {
        
        
        
        print("Code start, statement");

        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {

            DialogueOptionReply("Reply1"+"["+dialogueGeneration+"]");
            dialogueGeneration += 1;
            

        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            DialogueOptionReply("Reply2" + "[" + dialogueGeneration + "]");
            dialogueGeneration += 1;


        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            DialogueOptionReply("Reply3" + "[" + dialogueGeneration + "]");
            dialogueGeneration += 1;


        }

    }

    void DialogueOptionReply(string DialogueReply)
    {
        print(DialogueReply);
    }
}
