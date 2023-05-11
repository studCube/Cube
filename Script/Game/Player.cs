using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Player : MonoBehaviour
{
    public GameObject[] playerPrefabs;
    public CinemachineVirtualCamera VCam;

    private int characterIndex;

    public static Vector2 lastCheckPointPos = new Vector2(0,-2);

    private void Awake()
    {
        characterIndex =  PlayerPrefs.GetInt("SelectedCharacter");
        GameObject player =  Instantiate(playerPrefabs[characterIndex], lastCheckPointPos, Quaternion.identity);
        VCam.m_Follow = player.transform;
    }

}
