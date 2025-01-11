using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectedPoster : MonoBehaviour
{
    //inputs
    [SerializeField] KeyCode up = KeyCode.W;
    [SerializeField] KeyCode down = KeyCode.S;
    [SerializeField] KeyCode back = KeyCode.A;
    [SerializeField] KeyCode forword = KeyCode.D;
    [SerializeField] KeyCode selected = KeyCode.Space;
    //pos
    [SerializeField] private Transform[] points = null;
    [SerializeField] public GameObject poster = null;
    private bool movingToTarget = false;
    private int witchOne;
    public int sceneLoad;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(up))
        {
            movingToTarget = true;
            witchOne = 0;
        }
        if (Input.GetKeyDown(down))
        {
            movingToTarget = true;
            witchOne = 1;
        }
        if (Input.GetKeyDown(back))
        {
            movingToTarget = true;
            witchOne = 2;
        }
        if (Input.GetKeyDown(forword))
        {
            movingToTarget = true;
            witchOne = 3;
        }
        if(movingToTarget)
        {
            transform.position = Vector3.MoveTowards(transform.position, points[witchOne].position, 10 * Time.deltaTime);
        }
        if (Input.GetKeyDown(selected))
        {
            if(!poster.activeSelf)
            {
                poster.SetActive(true);
            }
            else
            {
                poster.SetActive(false);
            }
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(NewShit(collision));
    }

    private IEnumerator NewShit(Collider2D collision)
    {
        yield return new WaitForSeconds(.25f);
        points = collision.gameObject.GetComponent<Poster>().points;
        poster = collision.gameObject.GetComponent<Poster>().poster;
        sceneLoad = collision.gameObject.GetComponent<Poster>().loadScene;
        movingToTarget = false;
        
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        poster.SetActive(false);
        poster = null;
    }
    public void playgame()
    {
        SceneManager.LoadScene(sceneLoad);
    }

}
