using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueScriptTest01 : MonoBehaviour
{
    public bool IsStartingStatement;
    public GameObject dialogueOption1;
    public string statementOption1;
    public GameObject dialogueOption2;
    public string statementOption2;
    public GameObject dialogueOption3;
    public string statementOption3;
    void Start()
    {
        Statement();
    }

   
    void Update()
    {
        if (IsStartingStatement == false)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {

            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {

            }

            if (Input.GetKeyDown(KeyCode.Alpha3))
            {

            }
        }
        





    }

    void Statement()
    {
        print("Statement");
    }
}
