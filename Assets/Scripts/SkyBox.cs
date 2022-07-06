using UnityEngine;

public class SkyBox : MonoBehaviour
{
    public SkyItemUI changeSky;
    public Skybox mainSkybox;

    void Start()
    {
        mainSkybox = changeSky.mainSkybox;
    }
}
