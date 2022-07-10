/*using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time;
    public bool buttonPressed = false;
    public GameObject slider;
    public Slider timeSlider;
    public float gameTime;
    float timer = 0f;
    private bool stopTimer = false;

    void Start()
    {
        timeSlider.maxValue = gameTime;
        timeSlider.value = gameTime;
    }

    void Update()
    {
        if(Magnet.ActivateCoin())
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
                //buttonPressed = false;
            }
            else
            {
                stopTimer = false;
            }
        }
    }
}*/
