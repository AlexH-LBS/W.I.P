using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{
    public string Name;
    public Dialogue Dialogue;

    private void Update()
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
