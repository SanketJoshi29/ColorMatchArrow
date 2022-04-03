using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunc : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenu;
    public GameObject powerUI;

    public void StartButton()
    {
        SceneManager.LoadScene("MainLevel");
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
        DisplayCoin.coinCount = 0;
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }

    public void PauseButton()
    {
        pauseMenu.SetActive(true);
        powerUI.SetActive(false);
        Time.timeScale = 0;
        GameIsPaused = true;
    }

    public void ContinueButton()
    {
        pauseMenu.SetActive(false);
        powerUI.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
}
