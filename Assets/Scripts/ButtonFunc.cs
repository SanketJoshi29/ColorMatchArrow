using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunc : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public Player movement;
    public GameObject pauseMenu;
    public GameObject powerUI;
    public Material skyboxOne;
    public Material skyboxTwo;

    public void RestartButton()
    {
        FindObjectOfType<SceneChanger>().FadeToScene("MainLevel");
        Time.timeScale = 1f;
        DisplayCoin.coinCountWithZero = 0;
    }

    public void MainMenuButton()
    {
        FindObjectOfType<SceneChanger>().FadeToScene("MainMenu");
        Time.timeScale = 1f;
    }

    public void PauseButton()
    {
        GameIsPaused = true;
        movement.enabled = false;
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
        powerUI.SetActive(false);    
    }

    public void ContinueButton()
    {
        GameIsPaused = false;
        movement.enabled = true;
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        powerUI.SetActive(true); 
    }
}
