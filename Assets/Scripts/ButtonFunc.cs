using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunc : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("MainLevel");
    }

    public void RestartButton()
    {
        FindObjectOfType<GameManager>().Restart();
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }



    public void PauseButton()
    {
        Time.timeScale = 0f;
        FindObjectOfType<GameManager>().PauseMenu();
        
    }
}
