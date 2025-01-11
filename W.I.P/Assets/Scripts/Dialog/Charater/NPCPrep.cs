using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prep : MonoBehaviour
{
    [SerializeField] public int romanceP;
    private void Start()
    {
            romanceP = Getint("romance");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        romanceP += DialogueManager.Instance.romancePoints;
        SetInt("romance", romanceP);

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
