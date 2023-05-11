using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockLevel : MonoBehaviour
{
    public int LevelNeed;
    public GameObject LockLevel;
    private int ActuallyLevel;

    void Update()
    {
        if(LevelNeed > ActuallyLevel)
        {
            gameObject.SetActive(false);
            LockLevel.SetActive(true);
        }
    }

    private void Awake()
    {
        ActuallyLevel = PlayerPrefs.GetInt("Level", 0);
    }
}
