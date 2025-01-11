using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField] public int romanceP;
    private void Start()
    {
            romanceP = Getint("romanceC");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        romanceP += DialogueManager.Instance.romancePoints;
        SetInt("romanceC", romanceP);

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
