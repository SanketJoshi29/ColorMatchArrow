﻿using UnityEngine;

public class PauseBGSound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().Pause();
    }
}
