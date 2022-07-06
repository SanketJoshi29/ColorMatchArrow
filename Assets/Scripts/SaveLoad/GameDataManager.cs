using System.Collections.Generic;

//Player Data Holder
[System.Serializable] public class PlayerData
{
	public int coins = 0;
}

//Power Data Holder
[System.Serializable] public class PowerData
{
	public int swapPowerCount = 0;
	public int randomPowerCount = 0;
	public int invisiblePowerCount = 0;
}

public static class GameDataManager
{
	static PlayerData playerData = new PlayerData ();
	static PowerData powerData = new PowerData();

	static GameDataManager ()
	{
		LoadPlayerData ();
		LoadPowerData();
	}

	//Player Data Methods -----------------------------------------------------------------------------
	
	public static int GetCoins ()
	{
		return playerData.coins;
	}

	public static void AddCoins (int amount)
	{
		playerData.coins += amount;
		SavePlayerData ();
	}

	public static bool CanSpendCoins (int amount)
	{
		return (playerData.coins >= amount);
	}

	public static void SpendCoins (int amount)
	{
		playerData.coins -= amount;
		SavePlayerData ();
	}

	static void LoadPlayerData ()
	{
		playerData = BinarySerializer.Load<PlayerData> ("player-data.txt");
		UnityEngine.Debug.Log ("<color=green>[PlayerData] Loaded.</color>");
	}

	static void SavePlayerData ()
	{
		BinarySerializer.Save (playerData, "player-data.txt");
		UnityEngine.Debug.Log ("<color=magenta>[PlayerData] Saved.</color>");
	}

	//Power Data Methods----------------------------------------------------------------------------

	public static int GetSwapCount()
	{
		return powerData.swapPowerCount;
	}
	public static int GetRandomCount()
	{
		return powerData.randomPowerCount;
	}
	public static int GetInvisibleCount()
	{
		return powerData.invisiblePowerCount;
	}

	public static void AddSwapCount(int amount)
	{
		powerData.swapPowerCount += amount;
		SavePowerData();
	}
	public static void AddRandomCount(int amount)
	{
		powerData.randomPowerCount += amount;
		SavePowerData();
	}
	public static void AddInvisibleCount(int amount)
	{
		powerData.invisiblePowerCount += amount;
		SavePowerData();
	}

	public static void SubtractSwapCount(int amount)
	{
		powerData.swapPowerCount -= amount;
		SavePowerData();
	}
	public static void SubtractRandomCount(int amount)
	{
		powerData.randomPowerCount -= amount;
		SavePowerData();
	}
	public static void SubtractInvisibleCount(int amount)
	{
		powerData.invisiblePowerCount -= amount;
		SavePowerData();
	}

	static void LoadPowerData ()
	{
		powerData = BinarySerializer.Load<PowerData> ("power-data.txt");
		UnityEngine.Debug.Log ("<color=green>[PowerData] Loaded.</color>");
	}

	static void SavePowerData ()
	{
		BinarySerializer.Save (powerData, "power-data.txt");
		UnityEngine.Debug.Log ("<color=magenta>[PowerData] Saved.</color>");
	}
}