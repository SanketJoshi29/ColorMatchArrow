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

    //Tramsparent
    public Material transparent;
    public BoxCollider b1;
    public float time = 10f;

    //RandomColor
    public Material[] randomColor;

    void Start()
    {
        swapPowerCountDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = " " + swapPowerCount;
    }
    void Update()
    {

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
        head.GetComponent<Renderer>().material = transparent;
        body.GetComponent<Renderer>().material = transparent;
        tail.GetComponent<Renderer>().material = transparent;
        b1.enabled = false;

        while(time >= 0)
        {
            time -= Time.deltaTime;
            head.GetComponent<Renderer>().material.color = Color.white;
            body.GetComponent<Renderer>().material.color = Color.white;
            tail.GetComponent<Renderer>().material.color = Color.white;
        }
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
}
