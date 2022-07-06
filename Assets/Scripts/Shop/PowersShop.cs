using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PowersShop : MonoBehaviour
{
    public TMP_Text swapText;
    public TMP_Text swapPriceText;

    public TMP_Text randomColorText;
    public TMP_Text randomColorPriceText;

    public TMP_Text invisibleText;
    public TMP_Text invisiblePriceText;

    public void BuySwapPowers()
    {
        if(GameDataManager.CanSpendCoins(100))
        {
            GameDataManager.SpendCoins(100);
            DisplayCoin.Instance.UpdateCoinsUIText(); 

            GameDataManager.AddSwapCount(1);
            PowerCount.Instance.UpdateSwapCountText();
        }
        else
        {
            Debug.Log("Not Enough Money");
        }
    }

    public void BuyRandomPowers()
    {
        if(GameDataManager.CanSpendCoins(200))
        {
            GameDataManager.SpendCoins(200);
            DisplayCoin.Instance.UpdateCoinsUIText(); 

            GameDataManager.AddRandomCount(1);
            PowerCount.Instance.UpdateRandomCountText();
        }
        else
        {
            Debug.Log("Not Enough Money");
        }
    }

    public void BuyInvisiblePowers()
    {
        if(GameDataManager.CanSpendCoins(300))
        {
            GameDataManager.SpendCoins(300);
            DisplayCoin.Instance.UpdateCoinsUIText(); 

            GameDataManager.AddInvisibleCount(1);
            PowerCount.Instance.UpdateInvisibleCountText();
        }
        else
        {
            Debug.Log("Not Enough Money");
        }
    }
}
