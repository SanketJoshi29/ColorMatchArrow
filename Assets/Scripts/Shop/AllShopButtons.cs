using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AllShopButtons : MonoBehaviour
{
    public Image popImage;
    public Image purchaseImage;
    public Button powerBtn;
    public Button skyBtn;

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

    public void PowerBtnMethod()
    {
        powerBtn.GetComponent<RectTransform>().sizeDelta = new Vector2(216f, 60f);
        powerBtn.transform.localPosition = new Vector3(-108f, 372f, 0f);
        skyBtn.GetComponent<RectTransform>().sizeDelta = new Vector2(216f, 45f);
        skyBtn.transform.localPosition = new Vector3(108f, 365f, 0f);
    }
    public void SkyBtnMethod()
    {
        skyBtn.GetComponent<RectTransform>().sizeDelta = new Vector2(216f, 60f);
        skyBtn.transform.localPosition = new Vector3(108f, 372f, 0f);
        powerBtn.GetComponent<RectTransform>().sizeDelta = new Vector2(216f, 45f);
        powerBtn.transform.localPosition = new Vector3(-108f, 365f, 0f);
    }
}
