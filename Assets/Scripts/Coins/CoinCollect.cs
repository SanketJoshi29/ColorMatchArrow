using UnityEngine;
using UnityEngine.UI;

public class CoinCollect : MonoBehaviour
{
    public float rotationSpeed = 5f;
    
    void Update()
    {
        transform.Rotate(0,rotationSpeed*Time.deltaTime,0, Space.World);
    }

    void OnTriggerEnter(Collider coin)
    {
        GameDataManager.AddCoins(1);
        this.gameObject.SetActive(false);
        DisplayCoin.Instance.UpdateCoinsUIText();

        DisplayCoin.coinCountWithZero += 1;
    }
}
