using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    public int zPos = 200;
    public bool creatingSection = false;
    public int secNum;
    public Transform head;

    void Update()
    {
        if(creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection()
    {
        secNum = Random.Range(0, 3);
        Instantiate(section[secNum], new Vector3(-1, 0, zPos), Quaternion.identity);
        zPos += 200;
        yield return new WaitForSeconds(15);
        creatingSection = false;
    }
}
