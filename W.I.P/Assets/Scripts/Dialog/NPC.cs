using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField] public int romanceP;
    private void OnTriggerExit2D(Collider2D collision)
    {
        romanceP = DialogueManager.Instance.romancePoints;
        DialogueManager.Instance.ResetRomancePoints();
    }
}
