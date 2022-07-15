using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    public void StartButton()
    {
        FindObjectOfType<SceneChanger>().FadeToScene("MainLevel");
        DisplayCoin.coinCountWithZero = 0;
    }

    public void ShopButton()
    {
        FindObjectOfType<SceneChanger>().FadeToScene("Shop");
    }

    public void TutorialButton()
    {
        FindObjectOfType<SceneChanger>().FadeToScene("Tutorial");
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
