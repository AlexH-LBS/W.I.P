using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int loadScene;
    public bool exit;
    public void LoadScene()
    {
        if(exit)
        {
            Application.Quit();
        }
        if(!exit)
        {
            SceneManager.LoadScene(loadScene);

        }
    }
}
