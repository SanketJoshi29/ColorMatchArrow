using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MuteManager : MonoBehaviour
{
    [SerializeField] Image musicOnIcon;
    [SerializeField] Image musicOffIcon;

    private bool muted = false;

    void Start()
    {
        if (!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted",0);
            Load();
        }
        else
        {
            Load();
        }
        AudioListener.pause = muted;
        UpdateMusicButtonIcon();
    }

    public void MusicMutePressed()
    {
        if(muted == false)
        {
            muted = true;
            //BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().Pause();
            AudioListener.pause = muted;     
        }
        else
        {
            muted = false;
            AudioListener.pause = muted;
            // BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().Play();
        }
        Save();
        UpdateMusicButtonIcon();
    }

    private void UpdateMusicButtonIcon()
    {
        if(muted == false)
        {
            musicOnIcon.enabled = true;
            musicOffIcon.enabled = false; 
        }
        else
        {
            musicOnIcon.enabled = false;
            musicOffIcon.enabled = true;
        }   
    }

    private void Load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    }

    private void Save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }
}
