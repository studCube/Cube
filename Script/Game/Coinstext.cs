using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Coinstext : MonoBehaviour
{
    public TextMeshProUGUI coinsText;
    public static int numberOfCoins;

    void Update()
    {
		numberOfCoins = PlayerPrefs.GetInt("NumberOfCoins", 0);
        coinsText.text = numberOfCoins.ToString();
    }
}
