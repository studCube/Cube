using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamePosition : MonoBehaviour
{
    public Transform target; // Objekt, který má být následován

    void Update()
    {
        // Nastavte pozici aktuálního objektu na pozici cílového objektu
        transform.position = target.position;
        transform.rotation = target.rotation;
    }
}

