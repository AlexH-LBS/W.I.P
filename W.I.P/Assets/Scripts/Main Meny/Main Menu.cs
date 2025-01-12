using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int loadScene;
    public void LoadScene()
    {
        SceneManager.LoadScene(loadScene);
    }
}
