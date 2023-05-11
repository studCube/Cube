using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPrefs : MonoBehaviour
{
    public int selectedCharacter;
    public int coinNumber;
    public int LevelCompleted;

    public void Set()
    {
        PlayerPrefs.SetInt("SelectedCharacter", selectedCharacter);

        PlayerPrefs.SetInt("NumberOfCoins", coinNumber);
        
        PlayerPrefs.SetInt("Level", LevelCompleted);
    }
}
