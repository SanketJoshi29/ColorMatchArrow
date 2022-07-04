using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Powers : MonoBehaviour
{
    public TMP_Text swapText;
    public static int swapCount = 0;
    public int swapPrice;
    public TMP_Text swapPriceText;


    public TMP_Text randomColorText;
    public int randomColorPrice;
    public TMP_Text invisibleText;
    public int invisiblePrice;

    void Start()
    {
        swapPriceText.GetComponent<TMPro.TextMeshProUGUI>().text = " " + swapPrice;
    }

    public void BuyPowers()
    {
        if(GameDataManager.CanSpendCoins(swapPrice))
        {
            GameDataManager.SpendCoins(swapPrice);
            DisplayCoin.Instance.UpdateCoinsUIText(); 
            swapCount++;
            swapText.GetComponent<TMPro.TextMeshProUGUI>().text = " " + swapCount;
        }
        else
        {
            Debug.Log("Not Enough Money");
        }
    }
}
