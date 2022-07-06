using UnityEngine;
using TMPro;

public class PowerCount : MonoBehaviour
{
    #region Singleton class: PowerCount

	public static PowerCount Instance;

	void Awake ()
	{
		if (Instance == null) {
			Instance = this;
		}
	}

	#endregion

    [SerializeField] TMP_Text swapCount;
    [SerializeField] TMP_Text randomCount;
    [SerializeField] TMP_Text invisibleCount;

    void Start()
    {
        UpdateSwapCountText();
        UpdateRandomCountText();
        UpdateInvisibleCountText();
    }

    public void UpdateSwapCountText()
    {
        SetPowerCountText(swapCount, GameDataManager.GetSwapCount());
    }
    public void UpdateRandomCountText()
    {
        SetPowerCountText(randomCount, GameDataManager.GetRandomCount());
    }
    public void UpdateInvisibleCountText()
    {
        SetPowerCountText(invisibleCount, GameDataManager.GetInvisibleCount());
    }
    
    void SetPowerCountText(TMP_Text textMesh, int value)
    {
        textMesh.text = value.ToString();
    }
}
