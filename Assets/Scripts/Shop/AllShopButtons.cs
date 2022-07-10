using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AllShopButtons : MonoBehaviour
{
    public Image popImage;
    public Image purchaseImage;

    public void Back()
    {
        FindObjectOfType<SceneChanger>().FadeToScene("MainMenu");
    }

    public void OkBtn()
    {
        FindObjectOfType<PowersShop>().PopOutUI(popImage);
    }

    public void OkBtnTwo()
    {
        FindObjectOfType<PowersShop>().PurchasedPopOutUI(purchaseImage);
    }
}
