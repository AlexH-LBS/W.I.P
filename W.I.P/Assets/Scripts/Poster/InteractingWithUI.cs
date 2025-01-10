using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractingWithUI : MonoBehaviour
{
    public int scene;
    public void playgame()
    {
        SceneManager.LoadScene(scene);
    }
}
