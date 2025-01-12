using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{
    public string Name;
    public Dialogue Dialogue;
    public senariodialog senariodialog;

    private void Start()
    {
        Dialogue = senariodialog.GetComponent<Dialogue>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        DialogueManager.Instance.StartDialogue(name, Dialogue.RootNode);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        DialogueManager.Instance.HideDialogue();
        senariodialog.senarioSelect();
        Dialogue = senariodialog.GetComponent<Dialogue>();
    }



}
