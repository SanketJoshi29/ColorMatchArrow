using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunc : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public Player movement;
    public GameObject pauseMenu;
    public GameObject powerUI;
    public GameObject panel;
    public AudioSource music;

    public void RestartButton()
    {
        FindObjectOfType<SceneChanger>().FadeToScene("MainLevel");
        Time.timeScale = 1f;
        DisplayCoin.coinCountWithZero = 0;
    }

    public void MainMenuButton()
    {
        FindObjectOfType<SceneChanger>().FadeToScene("MainMenu");
        BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().Play();
        Time.timeScale = 1f;
    }

    public void PauseButton()
    {
        GameIsPaused = true;
        movement.enabled = false;
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
        powerUI.SetActive(false); 
        panel.SetActive(true);

        if(GameIsPaused)
        {
            music.Pause();
        }  
    }

    public void ContinueButton()
    {
        GameIsPaused = false;
        movement.enabled = true;
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        powerUI.SetActive(true);
        panel.SetActive(false);

        if(GameIsPaused == false)
        {
            music.Play();
        }
    }
}
