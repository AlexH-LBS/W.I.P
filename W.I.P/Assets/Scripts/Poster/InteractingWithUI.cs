using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractingWithUI : MonoBehaviour
{
    public int selectedPoster;
    public void playgame()
    {
        selectedPoster = GetComponent<SelectedPoster>().sceneLoad;
        SceneManager.LoadScene(selectedPoster);
    }
}
