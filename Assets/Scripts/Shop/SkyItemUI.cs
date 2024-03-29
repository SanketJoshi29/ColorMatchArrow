using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SkyItemUI : MonoBehaviour
{
	public SkyShopDatabase shopData;
	public GameObject[] skyImages;
	public TMP_Text unlockBtnText;
	public Button unlockBtn, nextBtn, previousBtn, clearBtn;
	public SkySaveLoad skySaveLoad;
	public Skybox mainSkybox;
	public GameObject[] grounds;
	public Image popImage;
	public Image purchaseImage;
	public AudioSource purchaseSound;

	private int currentIndex = 0;
	private int selectedIndex = 0;

	private void Start()
	{
		skySaveLoad.Initialized();
		selectedIndex = PlayerPrefs.GetInt("SelectedItem", 0);
		currentIndex = selectedIndex;

		unlockBtn.onClick.AddListener(()=> UnlockSelectBtnMethod());
		nextBtn.onClick.AddListener(()=> NextBtnMethod());
		previousBtn.onClick.AddListener(()=> PreviousBtnMethod());
		clearBtn.onClick.AddListener(()=> ClearCache());

		skyImages[currentIndex].SetActive(true);

		if(currentIndex == 0)
			previousBtn.interactable = false;
		
		if(currentIndex == shopData.shopItems.Length - 1)
			nextBtn.interactable = false;
		
		UnlockSelectBtnStatus();
	}

	private void NextBtnMethod()
	{
		if(currentIndex < shopData.shopItems.Length - 1)
		{
			skyImages[currentIndex].SetActive(false);
			currentIndex++;
			skyImages[currentIndex].SetActive(true);

			if(currentIndex == shopData.shopItems.Length - 1)
				nextBtn.interactable = false;
			
			if(!previousBtn.interactable)
				previousBtn.interactable = true;

			UnlockSelectBtnStatus();
		}
	}

	private void PreviousBtnMethod()
	{
		if(currentIndex > 0)
		{
			skyImages[currentIndex].SetActive(false);
			currentIndex--;
			skyImages[currentIndex].SetActive(true);

			if(currentIndex == 0)
				previousBtn.interactable = false;
			if(!nextBtn.interactable)
				nextBtn.interactable = true;

			UnlockSelectBtnStatus();
		}
	}

	private void UnlockSelectBtnMethod()
	{
		bool isSelected = false;
		if(shopData.shopItems[currentIndex].isUnlock)
		{
			isSelected = true;
		}
		else
		{
			if(GameDataManager.CanSpendCoins(shopData.shopItems[currentIndex].unlockCost))
			{
				GameDataManager.SpendCoins(shopData.shopItems[currentIndex].unlockCost);
				DisplayCoin.Instance.UpdateCoinsUIText();
				isSelected = true;
				shopData.shopItems[currentIndex].isUnlock = true;
				mainSkybox.material = shopData.shopItems[currentIndex].skybox;
				foreach(GameObject ground in grounds) 
				{
         			ground.GetComponent<Renderer>().material = shopData.shopItems[currentIndex].groundColor;
  				}
				PlayerPrefs.SetInt("SkyBoxSelected", currentIndex);
				FindObjectOfType<PowersShop>().PurchasedPopInUI(purchaseImage);
				purchaseSound.Play();
				skySaveLoad.SaveData();
			}
			else
			{
				FindObjectOfType<PowersShop>().PopInUI(popImage);
				Debug.Log("Not Enough Money");
			}	
		}

		if(isSelected)
		{
			unlockBtnText.text = "Selected";
			selectedIndex = currentIndex;
			PlayerPrefs.SetInt("SelectedItem", selectedIndex);
			unlockBtn.interactable = false;
		}	
	}

	private void UnlockSelectBtnStatus()
	{
		if(shopData.shopItems[currentIndex].isUnlock)
		{
			unlockBtn.interactable = selectedIndex != currentIndex ? true : false;
			unlockBtnText.text = selectedIndex == currentIndex ? "Selected" : "Select";
		}
		else
		{
			unlockBtn.interactable = true;
			unlockBtnText.text = " " + shopData.shopItems[currentIndex].unlockCost;
		}
	}

	public void EquipBtn()
	{
		if(unlockBtnText.text == "Select")
		{
			mainSkybox.material = shopData.shopItems[currentIndex].skybox;
			PlayerPrefs.SetInt("SkyBoxSelected", currentIndex);
		}
	}
	public void ClearCache()
	{
		skySaveLoad.ClearData();
	}
}




