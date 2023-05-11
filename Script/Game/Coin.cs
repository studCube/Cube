using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coin : MonoBehaviour
{

    [SerializeField] AudioSource CoinSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "Player")
        {
            Coinstext.numberOfCoins++;
            CoinSoundEffect.Play();
            PlayerPrefs.SetInt("NumberOfCoins", Coinstext.numberOfCoins);
            Destroy(gameObject);
        }
    }
}
