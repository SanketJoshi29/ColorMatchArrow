using UnityEngine;
using UnityEngine.UI;

public class TutorialPower : MonoBehaviour
{
    //Swap---------------------------------------------------------
    [Header ("Swap Power")]
    public GameObject head;
    public GameObject body;
    public GameObject tail;
    Material swap;

    //Transparent---------------------------------------------------
    [Space (20f)]
    [Header ("Invisible Power")]
    public Material transparent;
    public BoxCollider boxCollider;
    public float time;
    public Button invisibleBtn;
    public bool buttonPressed = false;
    public GameObject slider;
    public Slider timeSlider;
    public float gameTime;
    float timer = 0f;
    private bool stopTimer = false;
    Material headSwap;
    Material bodySwap;
    Material tailSwap;

    //RandomColor------------------------------------------------------
    [Space (20f)]
    [Header ("RandomColor Power")]
    public Material[] randomColor;

    void Start()
    {
        timeSlider.maxValue = gameTime;
        timeSlider.value = gameTime;
    }
    void FixedUpdate()
    {
        if(buttonPressed == true)
        {
            slider.SetActive(true);
            timer += Time.fixedDeltaTime;
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
                buttonPressed = false;
                head.GetComponent<Renderer>().material = headSwap;
                body.GetComponent<Renderer>().material = bodySwap;
                tail.GetComponent<Renderer>().material = tailSwap;
                boxCollider.enabled = true;
                invisibleBtn.interactable = true;
            }
            else
            {
                stopTimer = false;
            }
        }
    }

    public void ColorSwap()
    {
        swap = head.GetComponent<Renderer>().material;
        head.GetComponent<Renderer>().material = body.GetComponent<Renderer>().material;
        body.GetComponent<Renderer>().material = swap; 
    }

    public void RandomColor()
    {
        if(head.GetComponent<Renderer>().material.color == Color.white 
            && body.GetComponent<Renderer>().material.color == Color.white
                && tail.GetComponent<Renderer>().material.color == Color.white)
        {
            head.GetComponent<Renderer>().material = randomColor[Random.Range(0, randomColor.Length)];
            body.GetComponent<Renderer>().material = head.GetComponent<Renderer>().material;
            tail.GetComponent<Renderer>().material = head.GetComponent<Renderer>().material;
        }
    }

    public void Transparent()
    {
        buttonPressed = true;
        headSwap = head.GetComponent<Renderer>().material;
        bodySwap = body.GetComponent<Renderer>().material;
        tailSwap = tail.GetComponent<Renderer>().material;
        head.GetComponent<Renderer>().material = transparent;
        body.GetComponent<Renderer>().material = transparent;
        tail.GetComponent<Renderer>().material = transparent;
        boxCollider.enabled = false;
        invisibleBtn.interactable = false;
    }
}
