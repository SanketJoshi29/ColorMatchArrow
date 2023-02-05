using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    public GameObject panel;
    public GameObject[] text;
    public GameObject nextBtn;
    public Player movement;
    public BoxCollider[] boxCollider;
    public GameObject swapBtn;
    public GameObject randomBtn;
    public GameObject invisibleBtn;
    public GameObject menuBtn;
    public GameObject restartBtn;
    public GameObject[] arrow;


    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "TriggerOne")
        {
            movement.moveForward = 0.1f;
            panel.SetActive(true);
            text[0].SetActive(true);
            nextBtn.SetActive(true);
            boxCollider[0].enabled = false;
        }
        if(collisionInfo.collider.tag == "TriggerTwo")
        {
            movement.moveForward = 0.1f;
            panel.SetActive(true);
            text[1].SetActive(true);
            nextBtn.SetActive(true);
            boxCollider[1].enabled = false;
        }
        if(collisionInfo.collider.tag == "TriggerThree")
        {
            movement.moveForward = 0.1f;
            panel.SetActive(true);
            text[2].SetActive(true);
            nextBtn.SetActive(true);
            boxCollider[2].enabled = false;
        }
        if(collisionInfo.collider.tag == "TriggerFour")
        {
            movement.moveForward = 0.1f;
            panel.SetActive(true);
            text[3].SetActive(true);
            nextBtn.SetActive(true);
            boxCollider[3].enabled = false;
        }
        if(collisionInfo.collider.tag == "TriggerFive")
        {
            movement.moveForward = 0.1f;
            panel.SetActive(true);
            text[4].SetActive(true);
            nextBtn.SetActive(true);
            boxCollider[4].enabled = false;
        }
        if(collisionInfo.collider.tag == "TriggerSix")
        {
            movement.moveForward = 0.1f;
            panel.SetActive(true);
            text[5].SetActive(true);
            boxCollider[5].enabled = false;
            arrow[2].SetActive(true);
            swapBtn.SetActive(true);
        }
        if(collisionInfo.collider.tag == "TriggerSeven")
        {
            movement.moveForward = 0.1f;
            panel.SetActive(true);
            text[6].SetActive(true);
            boxCollider[6].enabled = false;
            arrow[0].SetActive(true);
            randomBtn.SetActive(true);
        }
        if(collisionInfo.collider.tag == "TriggerEight")
        {
            movement.moveForward = 0.1f;
            panel.SetActive(true);
            text[7].SetActive(true);
            boxCollider[7].enabled = false;
            arrow[1].SetActive(true);
            invisibleBtn.SetActive(true);
        }
        if(collisionInfo.collider.tag == "TriggerNine")
        {
            panel.SetActive(true);
            text[8].SetActive(true);
            menuBtn.SetActive(true);
            boxCollider[8].enabled = false;
        }
    }

    public void NextButtonMethod()
    {
        movement.moveForward = 7f;
        panel.SetActive(false);
        for (int i = 0; i < text.Length; i++)
        {
            text[i].SetActive(false);
        }
        nextBtn.SetActive(false);
    }

    public void MenuButtonMethod()
    {
        FindObjectOfType<SceneChanger>().FadeToScene("MainMenu");
        BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().Play();
    }
    
    public void RestartButton()
    {
        FindObjectOfType<SceneChanger>().FadeToScene("Tutorial");
        Time.timeScale = 1f;
    }

    public void BackButton()
    {
        FindObjectOfType<SceneChanger>().FadeToScene("MainMenu");
        Time.timeScale = 1f;
        BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().Play();
    }
}
