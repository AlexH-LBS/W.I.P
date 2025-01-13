using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{
    public string Name;
    public Dialogue Dialogue;
    public senariodialog senariodialog;
    public bool isfiller;
    public BusMovement BusMovement;

    private void Start()
    {
        Dialogue = senariodialog.GetComponent<Dialogue>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            DialogueManager.Instance.StartDialogue(Name, Dialogue.RootNode);
            BusMovement.move = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        DialogueManager.Instance.HideDialogue();
        senariodialog.senarioSelect(isfiller = true);
        Dialogue = senariodialog.GetComponent<senariodialog>().TrueDialouge;
    }
    public void BackFromGig()
    {
        isfiller = false;
    }



}
