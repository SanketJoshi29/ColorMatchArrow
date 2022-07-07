using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public Animator animator;
    string levelName;
    string levelToLoad;
    public bool isFading = false;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void FadeToScene(string levelToLoad)
    {
        levelName = levelToLoad;
        if(!isFading)
        {
            StartCoroutine(Fade());
        }
    }

    IEnumerator Fade()
    {
        isFading = true;
        animator.SetBool("FadeOut", true);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(levelName);
    }
}
