using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxSave : MonoBehaviour
{
    public int index;
    public Material[] skyboxCollection;
    public Skybox mainSkybox;

    void Start()
    {
        index = PlayerPrefs.GetInt("SkyBoxSelected");
        mainSkybox.material = skyboxCollection[index];     
    }
}
