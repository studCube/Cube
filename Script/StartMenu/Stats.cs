using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Stats : MonoBehaviour
{
    public static int selectedCharacter;
    public static int coinNumber;
    public static int LevelCompleted;
    
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI LevelText;
    public TextMeshProUGUI SelectedCharacter;

    void Update()
    {
        selectedCharacter = PlayerPrefs.GetInt("SelectedCharacter", 0);
        coinNumber = PlayerPrefs.GetInt("NumberOfCoins", 0);
        LevelCompleted = PlayerPrefs.GetInt("Level", 0);

        coinText.text = coinNumber.ToString();
        LevelText.text = LevelCompleted.ToString();
        SelectedCharacter.text = selectedCharacter.ToString();
    }
}
