using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class senariodialog : MonoBehaviour
{
    public Dialogue[] Dialogue;
    public Dialogue[] FillerDialogue;
    public Dialogue TrueDialouge;
    private int slected = 1;
    public int random;
    public void senarioSelect(bool isFiller)
    {
        if(!isFiller)
        {
            TrueDialouge = Dialogue[slected];
            slected += 1;
        }
        if(isFiller)
        {
            fillerSenario();
        }

    }
    public void fillerSenario()
    {
        for (random = 0; random < FillerDialogue.Length; random++)
        {
            Dialogue tmp = FillerDialogue[random];
            int r = Random.Range(random, FillerDialogue.Length);

            TrueDialouge = FillerDialogue[r];
        }

    }
}
