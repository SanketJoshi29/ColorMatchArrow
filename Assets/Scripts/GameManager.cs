using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameHasEnded = false;
    public GameObject crashMenu;
    public GameObject powerUI;
    public GameObject panel;

    public int target = 60;

    public void FixedUpdate()
    {
        if (target != Application.targetFrameRate)
        {
            Application.targetFrameRate = target;
        }   
    }

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
        panel.SetActive(true);
    }
}
