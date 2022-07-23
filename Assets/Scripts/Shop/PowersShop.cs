using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PowersShop : MonoBehaviour
{
    public TMP_Text swapCountText;
    public TMP_Text randomColorCountText;
    public TMP_Text invisibleCountText;
    public GameObject panel;

    public Animator popUpAnimator;
    public Image popImage;
    public bool isPoping = false;

    public Animator purchaseAnimator;
    public Image purchaseImage;
    public bool isPurchasedPoping = false;

    public void PopInUI(Image popImage)
    {
        isPoping = true;
        panel.SetActive(true);
        popUpAnimator.SetBool("PopUp_Out", true);
    }

    public void PopOutUI(Image popImage)
    {
        isPoping = false;
        panel.SetActive(false);
        popUpAnimator.SetBool("PopUp_Out", false);
    }

    public void PurchasedPopInUI(Image purchaseImage)
    {
        isPurchasedPoping = true;
        panel.SetActive(true);
        purchaseAnimator.SetBool("Purchase_Out", true);
    }

    public void PurchasedPopOutUI(Image purchaseImage)
    {
        isPurchasedPoping = false;
        panel.SetActive(false);
        purchaseAnimator.SetBool("Purchase_Out", false);
    }
    
    public void BuySwapPowers()
    {
        if(GameDataManager.CanSpendCoins(10))
        {
            GameDataManager.SpendCoins(10);
            DisplayCoin.Instance.UpdateCoinsUIText(); 

            GameDataManager.AddSwapCount(1);
            PowerCount.Instance.UpdateSwapCountText();
            PurchasedPopInUI(purchaseImage);
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
            PurchasedPopInUI(purchaseImage);
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
            PurchasedPopInUI(purchaseImage);
        }
        else
        {
            Debug.Log("Not Enough Money");
            PopInUI(popImage);
        }
    }
}
