using UnityEngine;
using UnityEngine.UI;

public class TotalCoins : MonoBehaviour
{
    public int previousCoinsCollected;
    public static int totalCoinsCollected;
    public int newCoinsCollected;
    public GameObject coinsCollectedDisplay;

    void Start()
    {
        //PlayerPrefs.DeleteAll();
        newCoinsCollected = PlayerPrefs.GetInt("CoinsCollected");
        previousCoinsCollected =  PlayerPrefs.GetInt("TotalCoinsCollected");
        totalCoinsCollected = newCoinsCollected + previousCoinsCollected;
        coinsCollectedDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = " " + totalCoinsCollected;
    }
}
