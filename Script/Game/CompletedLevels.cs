using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompletedLevels : MonoBehaviour
{
    public int NextLevel;
    public static int ActuallyLevel;

    void Update()
    {
        ActuallyLevel = PlayerPrefs.GetInt("Level");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "Player")
        {
            if(ActuallyLevel < NextLevel)
            {
                PlayerPrefs.SetInt("Level", NextLevel);
            }

            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
    }
}
