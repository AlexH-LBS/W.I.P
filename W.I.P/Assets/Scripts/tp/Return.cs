using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Return : MonoBehaviour
{
    public int loadScene;
    public Popularity Popularity;
    public TextMeshProUGUI fameText;
    public float fameint;

    private void Update()
    {
        fameint = Popularity.GetComponent<Popularity>().fameInt;
        fameText.text = fameint.ToShortString(4);
    }
    public void LoadScene()
    {
        SceneManager.LoadScene(loadScene);
    }
    public void unhide()
    {
        gameObject.SetActive(true);
    }
}
