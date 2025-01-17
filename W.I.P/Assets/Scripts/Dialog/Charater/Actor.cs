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
    public GameObject charaterImg;
    public bool isPlayerNearby;
    private void Start()
    {
        Dialogue = senariodialog.GetComponent<Dialogue>();

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isPlayerNearby)
        {
            DialogueManager.Instance.StartDialogue(Name, Dialogue.RootNode, charaterImg);
            BusMovement.move = false;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Cowboy")
        {
            isPlayerNearby = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isPlayerNearby = false;
        DialogueManager.Instance.HideDialogue(charaterImg);
        senariodialog.senarioSelect(isfiller = false);
        Dialogue = senariodialog.GetComponent<senariodialog>().TrueDialouge;
    }
    public void BackFromGig()
    {
        isfiller = false;
    }



}
