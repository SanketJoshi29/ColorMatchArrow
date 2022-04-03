using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameHasEnded = false;
    public float restartDelayTime = 1f;
    public GameObject crashMenu;
    public GameObject pauseMenu;
    public GameObject powerUI;
    public static bool GameIsPaused = false;

    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            //Invoke("Restart" , restartDelayTime);      //Invoke take two parameters. 1st - function to be called & 2nd - Delaytime
        }
    }

    public void CrashMenu()
    {
        crashMenu.SetActive(true);
        powerUI.SetActive(false);   
    }
}
