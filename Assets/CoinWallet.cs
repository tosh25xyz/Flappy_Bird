
using UnityEngine;
using TMPro;

public class CoinWallet : MonoBehaviour
{
    public TMP_Text coinText;

    private int totalCoins;

    void Awake()
    {
        // Load previously saved coins
        totalCoins = PlayerPrefs.GetInt("TotalCoins", 0);
         
        UpdateUI();
    }

    public void AddCoins(int amount)
    {
        totalCoins += amount;

        // Save the new total permanently
        PlayerPrefs.SetInt("TotalCoins", totalCoins);
        PlayerPrefs.Save();

        UpdateUI();
    }

    void UpdateUI()
    {
        if (coinText != null)
        {
            coinText.text = "Coins: " + totalCoins;
        }
    }
}
