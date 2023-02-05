using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    private string url;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

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

    public void MoreGames(string url)
    {
        Application.OpenURL(url);
    }
}
