using UnityEngine;
using TMPro;

public class DisplayCoin : MonoBehaviour
{
	#region Singleton class: DisplayCoin

	public static DisplayCoin Instance;

	void Awake ()
	{
		if (Instance == null) {
			Instance = this;
		}
	}

	#endregion

    public static int coinCountWithZero;
    public GameObject coinDisplayWithZero;

	[SerializeField] TMP_Text[] coinsUIText;

	void Start ()
	{
		UpdateCoinsUIText ();
	}
    void Update()
    {
        coinDisplayWithZero.GetComponent<TMPro.TextMeshProUGUI>().text = " " + coinCountWithZero;
    }

	public void UpdateCoinsUIText ()
	{
		for (int i = 0; i < coinsUIText.Length; i++) {
			SetCoinsText (coinsUIText [i], GameDataManager.GetCoins ());
		}
	}

	void SetCoinsText (TMP_Text textMesh, int value)
	{
		textMesh.text = value.ToString ();
	}
}