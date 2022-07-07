using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PowersShop : MonoBehaviour
{
    public TMP_Text swapCountText;
    public TMP_Text randomColorCountText;
    public TMP_Text invisibleCountText;

    public Animator animator;
    public Image popImage;
    public bool isPoping = false;

    public void PopInUI(Image popImage)
    {
        isPoping = true;
        animator.SetBool("PopUp_Out", true);
    }

    public void PopOutUI(Image popImage)
    {
        isPoping = false;
        animator.SetBool("PopUp_Out", false);
    }
    
    public void BuySwapPowers()
    {
        if(GameDataManager.CanSpendCoins(1))
        {
            GameDataManager.SpendCoins(10);
            DisplayCoin.Instance.UpdateCoinsUIText(); 

            GameDataManager.AddSwapCount(10);
            PowerCount.Instance.UpdateSwapCountText();
        }
        else
        {
            Debug.Log("Not Enough Money");
            PopInUI(popImage);
        }
    }

    public void BuyRandomPowers()
    {
        if(GameDataManager.CanSpendCoins(10))
        {
            GameDataManager.SpendCoins(10);
            DisplayCoin.Instance.UpdateCoinsUIText(); 

            GameDataManager.AddRandomCount(1);
            PowerCount.Instance.UpdateRandomCountText();
        }
        else
        {
            Debug.Log("Not Enough Money");
            PopInUI(popImage);
        }
    }

    public void BuyInvisiblePowers()
    {
        if(GameDataManager.CanSpendCoins(10))
        {
            GameDataManager.SpendCoins(10);
            DisplayCoin.Instance.UpdateCoinsUIText(); 

            GameDataManager.AddInvisibleCount(1);
            PowerCount.Instance.UpdateInvisibleCountText();
        }
        else
        {
            Debug.Log("Not Enough Money");
            PopInUI(popImage);
        }
    }
}
