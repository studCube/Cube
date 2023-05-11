using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public float x;
    public float y;

    [SerializeField] AudioSource CheckPointSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            CheckPointSoundEffect.Play();
            Player.lastCheckPointPos = new Vector2(x, y);
        }
    }
}