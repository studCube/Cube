using Assets.SimpleLocalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiLanguage : MonoBehaviour
{
    private string Jazyk;

    private void Awake()
    {
        Jazyk = PlayerPrefs.GetString("LanguagePref");
    }

    void Start()
    {
        LocalizationManager.Read();

        LocalizationManager.Language = Jazyk;
    }

    public void Language(string language)
    {
        LocalizationManager.Language = language;
        PlayerPrefs.SetString("LanguagePref", language);
    }
}
