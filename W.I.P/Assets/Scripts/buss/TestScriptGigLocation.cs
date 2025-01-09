using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TestScriptGigLocation : MonoBehaviour
{
    // Start is called before the first frame update

    public bool isPlayerNearby;

    public GameObject characterPrompt;

    public int characterScene;

    void Start()
    {
        characterPrompt.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerNearby == true)
        {

            characterPrompt.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(characterScene);
            }
        }
        else
        {
            characterPrompt.SetActive(false);
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
