using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public int Level;

    public void LevelLoad()
    {
        SceneManager.LoadScene(Level);
    }
}
