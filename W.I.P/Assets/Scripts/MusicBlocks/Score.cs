using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Score : MonoBehaviour
{
    public static Score Instance { get; private set; }//make it refrnced in other scripts without doing fcking script sheit
    private void Awake()
    {
        // Singleton pattern to ensure only one instance of DialogueManager
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

    }

    public TextMeshProUGUI scoreDisplay;
    public int totalHits;

    public void addPoints(int added)
    {
        totalHits = added;
        scoreDisplay.text = totalHits.ToString();
    }
}
