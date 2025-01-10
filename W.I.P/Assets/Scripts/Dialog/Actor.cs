using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{
    public string Name;
    public Dialogue Dialogue;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpeakTo();
        }
    }

    public void SpeakTo()
    {
        DialogueManager.Instance.StartDialogue(name, Dialogue.RootNode);
    }
}
