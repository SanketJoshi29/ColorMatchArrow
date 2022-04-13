using UnityEngine;
using UnityEngine.SceneManagement;

public class AllShopButtons : MonoBehaviour
{
    public void Back()
    {
        FindObjectOfType<SceneChanger>().FadeToScene("MainMenu");
        PlayerPrefs.SetInt("TotalCoinsCollected", TotalCoins.totalCoinsCollected);
    }
}
