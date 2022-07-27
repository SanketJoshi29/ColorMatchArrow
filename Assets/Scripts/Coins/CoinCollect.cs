using UnityEngine;
using UnityEngine.UI;

public class CoinCollect : MonoBehaviour
{
    public float rotationSpeed = 5f;

    public Transform playerTransform;
    public float moveSpeed = 17f;
    CoinMove coinMoveScript;
    
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        coinMoveScript = gameObject.GetComponent<CoinMove>();
    }

    void Update()
    {
        transform.Rotate(0,rotationSpeed*Time.deltaTime,0, Space.World);
    }

    void OnTriggerEnter(Collider coin)
    {
        if(coin.gameObject.tag == "Coin Detector")
        {
            coinMoveScript.enabled = true;
        }
        
        if(coin.gameObject.tag == "Player")
        {
            GameDataManager.AddCoins(1);
            this.gameObject.SetActive(false);
            DisplayCoin.Instance.UpdateCoinsUIText();

            DisplayCoin.coinCountWithZero += 1;
        }
        if(coin.gameObject.tag == "Player Bubble")
        {
            GameDataManager.AddCoins(1);
            this.gameObject.SetActive(false);
            DisplayCoin.Instance.UpdateCoinsUIText();

            DisplayCoin.coinCountWithZero += 1;
        }
    }
}