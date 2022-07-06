using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkySaveLoad : MonoBehaviour
{
    [SerializeField] private SkyItemUI skyUI;

    public void Initialized()
    {   
        if(PlayerPrefs.GetInt("GameStartedFirstTime") == 1)
            LoadData();
        else
        {
            SaveData();
            PlayerPrefs.SetInt("GameStartedFirstTime", 1);
        } 
            
    }

    public void SaveData()
    {
        //convert the data to string
        string shopDataString = JsonUtility.ToJson(skyUI.shopData);
        Debug.Log("Save:" + shopDataString);

        try
        {
            //save the string as json 
            System.IO.File.WriteAllText(Application.persistentDataPath + "/SkyShopData.json", shopDataString);
            Debug.Log("<color=magenta>[SkyData] Saved </color>");

        }
        catch (System.Exception e)
        {
            //if we get any error debug it
            Debug.Log("Error Saving Data:" + e);
            throw;
        }
    }
    

    public void LoadData()
    {
        try
        {
            //get the text data from json and stro it in string
            string shopDataString = System.IO.File.ReadAllText(Application.persistentDataPath + "/SkyShopData.json");
            Debug.Log("Load:" + shopDataString);
            skyUI.shopData = new SkyShopDatabase();
            skyUI.shopData = JsonUtility.FromJson<SkyShopDatabase>(shopDataString); //create ShopData from json

            Debug.Log("<color=green>[SkyData] Loaded </color>");
        }
        catch (System.Exception e)
        {
            Debug.Log("Error Loading Data:" + e);
            throw;
        }
    }

    public void ClearData()
    {
        Debug.Log("Data Cleared");
        PlayerPrefs.SetInt("GameStartedFirstTime", 0);
    }
}
