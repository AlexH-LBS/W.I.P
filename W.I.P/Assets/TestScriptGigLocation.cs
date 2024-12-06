using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TestScriptGigLocation : MonoBehaviour
{
    // Start is called before the first frame update

    public bool isBusNearby;

    public GameObject gigPrompt;

    public int gigScene;

    void Start()
    {
        gigPrompt.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isBusNearby == true)
        {

            gigPrompt.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(gigScene);
            }
        }
        else
        {
            gigPrompt.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isBusNearby = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isBusNearby = false;
    }
}
