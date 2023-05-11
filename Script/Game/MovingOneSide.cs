using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingOneSide : MonoBehaviour
{
    public int direction;
    public float force;
    public float lifetime;
    void Start()
    {
        FindObjectOfType<Rigidbody2D>().AddForce(Vector2.left * force);
        Destroy(gameObject, lifetime);
    }
}
