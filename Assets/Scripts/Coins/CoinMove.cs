using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMove : MonoBehaviour
{
    CoinCollect coinCollectScript;

    void Start()
    {
        coinCollectScript = gameObject.GetComponent<CoinCollect>();
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, coinCollectScript.playerTransform.position, coinCollectScript.moveSpeed * Time.deltaTime);
    }
}
