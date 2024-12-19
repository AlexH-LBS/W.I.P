using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueScript : MonoBehaviour
{

    public bool IsFirstStatement;
    public bool isPrefabActive;

    public bool isOption1;
    public GameObject option1Prefab;
    public bool isOption2;
    public GameObject option2Prefab;
    public bool isOption3;
    public GameObject option3prefab;
    public bool leave;
    

    


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
                    isOption1 = true;
                    isOption2 = false;
                    isOption3 = false;
                    leave = false;
                    break;

                case DialoguePossibleOptions.option2:
                    isOption2 = true;

                    break;

                case DialoguePossibleOptions.option3:
                    isOption3 = true;

                    break;

                case DialoguePossibleOptions.leave:
                    leave = true;

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