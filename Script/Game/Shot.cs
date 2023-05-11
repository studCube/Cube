using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject shotPref;
    public Transform firePoint;
    public float attackRate;

    private float innerAttackRate = 0;

    [SerializeField] AudioSource ShotSoundEffect;

    void Update()
    {
        if(innerAttackRate >= attackRate)
        {
            Instantiate(shotPref, firePoint);
            innerAttackRate = 0;
            ShotSoundEffect.Play();
        }

        innerAttackRate += Time.deltaTime;
    }

}
