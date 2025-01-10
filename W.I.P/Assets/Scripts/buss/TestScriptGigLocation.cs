using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TestScriptGigLocation : MonoBehaviour
{
    // Start is called before the first frame update

    public bool isPlayerNearby;

    public GameObject Prompt;

    public int loadScene;

    void Start()
    {
        Prompt.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerNearby == true)
        {

            Prompt.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                //This happens if youre in range :>>>
                SceneManager.LoadScene(loadScene);
            }
        }
        else
        {
            Prompt.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isPlayerNearby = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isPlayerNearby = false;
    }
}
