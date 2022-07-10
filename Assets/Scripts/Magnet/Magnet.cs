using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Magnet : MonoBehaviour
{
    public float rotationSpeed = 5f;

    public GameObject coinDetectorObj;

    public float time;
    public bool triggered = false;
    public GameObject slider;
    public Slider timeSlider;
    public float gameTime;
    float timer = 0f;
    private bool stopTimer = false;

    void Start()
    {
        coinDetectorObj = GameObject.FindGameObjectWithTag("Coin Detector");
        coinDetectorObj.SetActive(false);

        timeSlider.maxValue = gameTime;
        timeSlider.value = gameTime;
    }

    void Update()
    {
        transform.Rotate(0,rotationSpeed*Time.deltaTime,0);

        if(triggered == true)
        {
            slider.SetActive(true);
            timer += Time.deltaTime;
            time = gameTime - timer;

            if(stopTimer == false)
            {
                timeSlider.value = time;
            }
            if(time <= 0)
            {
                stopTimer = true;
                slider.SetActive(false);
                timer = 0f;
                timeSlider.value = gameTime;
                triggered = false;
            }
            else
            {
                stopTimer = false;
            }
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            StartCoroutine(ActivateCoin());
            triggered = true;
            Destroy(transform.GetChild(0).gameObject);
        }
    }

    IEnumerator ActivateCoin()
    {
        coinDetectorObj.SetActive(true);
        yield return new WaitForSeconds(7f);
        coinDetectorObj.SetActive(false);
    }
}
