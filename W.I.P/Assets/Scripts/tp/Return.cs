using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Return : MonoBehaviour
{
    public int loadScene;
    public Popularity Popularity;
    public TextMeshProUGUI fameText;
    public float fameint;
    public int dialogue;

    private void Update()
    {
        fameint = Popularity.GetComponent<Popularity>().fameInt;
        fameText.text = fameint.ToShortString(4);
    }
    public void LoadScene()
    {
        PlayerPrefs.SetInt("dialogue", dialogue);//set the dialogue the player is on
        SceneManager.LoadScene(loadScene);
    }

}
