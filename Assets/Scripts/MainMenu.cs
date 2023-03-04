using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("Game");
    }
    public void QuitButton()
    {
        Application.Quit();
        Debug.Log("QUIT");
    }
}
