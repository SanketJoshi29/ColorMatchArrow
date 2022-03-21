using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform head;
    public TextMeshProUGUI score;

    // Update is called once per frame
    void Update()
    {
        score.text = head.position.z.ToString("0");
    }
}
