using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{
    public string Name;
    public Dialogue Dialogue;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        DialogueManager.Instance.StartDialogue(name, Dialogue.RootNode);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        DialogueManager.Instance.HideDialogue();
    }



}
