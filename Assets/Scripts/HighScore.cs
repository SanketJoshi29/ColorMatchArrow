using UnityEngine;

public class HighScore : MonoBehaviour
{
    public Transform head;

    void Start()
    {
        //PlayerPrefs.DeleteKey("HighScore");
        transform.position = new Vector3(18, 1.5f, PlayerPrefs.GetFloat("HighScore",0));
    }

    public void HighScoreData()
    {
        if(head.position.z > PlayerPrefs.GetFloat("HighScore",0))
        {
            PlayerPrefs.SetFloat("HighScore", head.position.z);
        }
    }

}
