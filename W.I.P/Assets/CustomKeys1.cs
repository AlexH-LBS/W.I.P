using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class ExampleClass : MonoBehaviour
{
    bool HasBeenClicked;
    public void Start()
    {
        HasBeenClicked = false;
    }
    public void setTrue()
    {
        HasBeenClicked = true;
        Debug.Log("Has been set true");
    }
    public void OnGUI()
    {
        Event e = Event.current;
        if (e.isKey && HasBeenClicked == true)
        {
            Debug.Log("Detected key code: " + e.keyCode);
            HasBeenClicked = false;
        }
    }
}