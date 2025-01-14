using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DialogueResponse
{
    //possible reponses and value of said reponse
    public string responseText;
    public int responseValue;
    public DialogueNode nextNode;

}
