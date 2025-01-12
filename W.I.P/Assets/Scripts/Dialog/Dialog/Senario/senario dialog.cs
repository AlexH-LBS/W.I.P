using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class senariodialog : MonoBehaviour
{
    public Dialogue[] Dialogue;
    public Dialogue TrueDialouge;
    public int slected = 1;
    public void senarioSelect()
    {
        TrueDialouge = Dialogue[slected];
        slected += 1;
    }
}
