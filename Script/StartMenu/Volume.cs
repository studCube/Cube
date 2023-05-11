using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volume : MonoBehaviour
{
    public void VolumeOn()
    {
        AudioListener.volume = 1;
    }

    public void VolumeOff()
    {
        AudioListener.volume = 0;
    }
}
