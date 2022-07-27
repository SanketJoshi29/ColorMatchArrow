using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxSave : MonoBehaviour
{
    public int index;
    public Material[] skyboxCollection;
    public Skybox mainSkybox;
    public Material[] groundCollection;
    public GameObject[] grounds;

    void Start()
    {
        index = PlayerPrefs.GetInt("SkyBoxSelected");
        mainSkybox.material = skyboxCollection[index];
        foreach(GameObject ground in grounds) 
        {
            ground.GetComponent<Renderer>().material = groundCollection[index];;
        }
    }
}
