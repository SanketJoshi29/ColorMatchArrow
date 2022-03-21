using UnityEngine;
using UnityEngine.UI;

public class DisplayCoin : MonoBehaviour
{
    public static int coinCount;
    public GameObject countDisplay;

    void Update()
    {
        countDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = " " + coinCount;
    }
}
