using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueScript : MonoBehaviour
{

    public bool IsFirstStatement;
    public bool isPrefabActive;

    public int choice;
    

    


    public enum DialoguePossibleOptions
    {
        option1,
        option2,
        option3,
        leave
    }

    public DialoguePossibleOptions DialogueOptions;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPrefabActive == true)
        {
            switch (DialogueOptions)
            {
                case DialoguePossibleOptions.option1:
                    
                    break;

                case DialoguePossibleOptions.option2:
                   

                    break;

                case DialoguePossibleOptions.option3:

                    break;

                case DialoguePossibleOptions.leave:

                    break;


            }

        }
    }

    void option1()
    {

    }
}
//notes
//wouldnt this also be possible with if statements? i mean what it does is check several things and run one thing, could probably make life easier idk. 