using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageFlag : MonoBehaviour
{
    private Image flag;
    public string Nationale;
    private string SelectedNationale;


    void Start()
    {
        flag = GetComponent<Image>();
    }

    void Update()
    {
        SelectedNationale = PlayerPrefs.GetString("LanguagePref");

        if (Nationale == SelectedNationale)
        {
            flag.enabled = true;
        }
        else
        {
            flag.enabled = false;
        }
    }
}
