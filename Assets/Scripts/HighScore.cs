using UnityEngine;

public class HighScore : MonoBehaviour
{
    public Transform head;

    void Start()
    {
        transform.position = new Vector3(18, 1.5f, PlayerPrefs.GetFloat("HighScore"));
    }

    public void HighScoreData()
    {
        PlayerPrefs.SetFloat("HighScore", head.position.z);
    }

}
