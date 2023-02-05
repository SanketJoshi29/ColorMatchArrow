using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PowersShop : MonoBehaviour
{
    public TMP_Text swapCountText;
    public TMP_Text randomColorCountText;
    public TMP_Text invisibleCountText;
    public GameObject panel;
    public AudioSource purchaseSound;

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

    public void BuyRandomPowers()
    {
        if(GameDataManager.CanSpendCoins(100))
        {
            GameDataManager.SpendCoins(100);
            DisplayCoin.Instance.UpdateCoinsUIText(); 

            GameDataManager.AddRandomCount(1);
            PowerCount.Instance.UpdateRandomCountText();
            PurchasedPopInUI(purchaseImage);
            purchaseSound.Play();
        }
        else
        {
            Debug.Log("Not Enough Money");
            PopInUI(popImage);
        }
    }
    
    public void BuySwapPowers()
    {
        if(GameDataManager.CanSpendCoins(150))
        {
            GameDataManager.SpendCoins(150);
            DisplayCoin.Instance.UpdateCoinsUIText(); 

            GameDataManager.AddSwapCount(1);
            PowerCount.Instance.UpdateSwapCountText();
            PurchasedPopInUI(purchaseImage);
            purchaseSound.Play();
        }
        else
        {
            Debug.Log("Not Enough Money");
            PopInUI(popImage);
        }
    }

    public void BuyInvisiblePowers()
    {
        if(GameDataManager.CanSpendCoins(200))
        {
            GameDataManager.SpendCoins(200);
            DisplayCoin.Instance.UpdateCoinsUIText(); 

            GameDataManager.AddInvisibleCount(1);
            PowerCount.Instance.UpdateInvisibleCountText();
            PurchasedPopInUI(purchaseImage);
            purchaseSound.Play();
        }
        else
        {
            Debug.Log("Not Enough Money");
            PopInUI(popImage);
        }
    }
}
