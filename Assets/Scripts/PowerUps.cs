using UnityEngine;

public class PowerUps : MonoBehaviour
{
    //Swap
    public GameObject head;
    public GameObject body;
    public GameObject tail;
    public int swapPowerCount = 5;
    public GameObject swapPowerCountDisplay;
    Material swap;

    //Transparent
    public Material transparent;
    public BoxCollider b1;
    public float time = 10f;
    public bool buttonPressed = false;

    //RandomColor
    public Material[] randomColor;
    public int randomPowerCount = 5;
    public GameObject randomPowerCountDisplay;

    void Start()
    {
        swapPowerCountDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = " " + swapPowerCount;
        randomPowerCountDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = " " + randomPowerCount;
    }
    void Update()
    {
        if(buttonPressed == true)
        {
            while(time >= 0)
            {
            time -= Time.deltaTime;
            head.GetComponent<Renderer>().material.color = Color.white;
            body.GetComponent<Renderer>().material.color = Color.white;
            tail.GetComponent<Renderer>().material.color = Color.white;
            }
        }
    }

    public void ColorSwap()
    {
        if(swapPowerCount != 0)
        {
            swap = head.GetComponent<Renderer>().material;
            head.GetComponent<Renderer>().material = body.GetComponent<Renderer>().material;
            body.GetComponent<Renderer>().material = swap;
            swapPowerCount--;
            swapPowerCountDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = " " + swapPowerCount;
        }
        
    }

    public void Transparent()
    {
        buttonPressed = true;
        head.GetComponent<Renderer>().material = transparent;
        body.GetComponent<Renderer>().material = transparent;
        tail.GetComponent<Renderer>().material = transparent;
        b1.enabled = false;

        
    }

    public void RandomColor()
    {
        if(randomPowerCount != 0)
        {
            if(head.GetComponent<Renderer>().material.color == Color.white 
                && body.GetComponent<Renderer>().material.color == Color.white
                    && tail.GetComponent<Renderer>().material.color == Color.white)
            {
                head.GetComponent<Renderer>().material = randomColor[Random.Range(0, randomColor.Length)];
                body.GetComponent<Renderer>().material = head.GetComponent<Renderer>().material;
                tail.GetComponent<Renderer>().material = head.GetComponent<Renderer>().material;
                randomPowerCount--;
                randomPowerCountDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = " " + randomPowerCount;
            }
        }
    }
}
