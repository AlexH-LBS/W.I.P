using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Pop : MonoBehaviour
{
    [SerializeField] public int romanceP;
    public bool end;
    private void Start()
    {
            romanceP = Getint("romanceP");
        string v = PlayerPrefs.GetString("end");
        if (v == "true")
        {
            end = true;
        }
        if (end)
        {
            endDialog.instance.compare(romanceP,0);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        romanceP += DialogueManager.Instance.romancePoints;
        SetInt("romanceP", romanceP);

        DialogueManager.Instance.ResetRomancePoints();
    }
    public void SetInt(string KeyName, int Value)
    {
        PlayerPrefs.SetInt(KeyName, Value);
    }

    public int Getint(string KeyName)
    {
        return PlayerPrefs.GetInt(KeyName);
    }
}
