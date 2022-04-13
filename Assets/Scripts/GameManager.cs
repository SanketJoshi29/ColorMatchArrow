using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameHasEnded = false;
    public GameObject crashMenu;
    public GameObject powerUI;

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
