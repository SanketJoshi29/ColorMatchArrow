using UnityEngine;

//[CreateAssetMenu (fileName = "SkyShopDatabase", menuName = "Shopping/Sky shop database")]
[System.Serializable]
public class SkyShopDatabase
{
	public int selectedIndex = 0;
	public ShopItem[] shopItems;
}

[System.Serializable]
public class ShopItem
{
	public string skyName;
	public int unlockCost;
	public Material skybox;
	public Material groundColor;
	public bool isUnlock;
}
