using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pop : MonoBehaviour
{
    [SerializeField] public int romanceP;
    private void Start()
    {
            romanceP = Getint("romanceP");
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
