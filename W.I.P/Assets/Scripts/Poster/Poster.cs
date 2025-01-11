using UnityEngine;

public class Poster : MonoBehaviour
{
    [SerializeField] public Transform[] points;
    [SerializeField] public GameObject poster;
    [SerializeField] public int loadScene;
    void Start()
    {

        poster.SetActive(false);
    }

}
