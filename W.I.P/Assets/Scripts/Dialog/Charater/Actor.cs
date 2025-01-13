using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{
    public string Name;
    public Dialogue Dialogue;
    public senariodialog senariodialog;
    public bool isfiller;

    private void Start()
    {
        Dialogue = senariodialog.GetComponent<Dialogue>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        DialogueManager.Instance.StartDialogue(Name, Dialogue.RootNode);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        DialogueManager.Instance.HideDialogue();
        senariodialog.senarioSelect(isfiller = true);
        Dialogue = senariodialog.GetComponent<senariodialog>().TrueDialouge;
    }



}
