using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunc : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenu;
    public GameObject powerUI;
    public Material skyboxOne;
     public Material skyboxTwo;

    public void RestartButton()
    {
        FindObjectOfType<SceneChanger>().FadeToScene("MainLevel");
        Time.timeScale = 1f;
        DisplayCoin.coinCount = 0;
    }

    public void MainMenuButton()
    {
        FindObjectOfType<SceneChanger>().FadeToScene("MainMenu");
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
    public void ChangeSkybox()
    {
        RenderSettings.skybox = skyboxOne;
        DynamicGI.UpdateEnvironment();
    }
    public void ChangeSkyboxBlue()
    {
        RenderSettings.skybox = skyboxTwo;
        DynamicGI.UpdateEnvironment();
    }
}
