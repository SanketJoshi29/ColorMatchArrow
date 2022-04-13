using UnityEngine;

public class HighScore : MonoBehaviour
{
    public Transform head;

    void Start()
    {
        //PlayerPrefs.DeleteAll();
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
