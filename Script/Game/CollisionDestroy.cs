using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDestroy : MonoBehaviour
{
    public float DestroyTime;

    private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.tag == "Player")
        {
			StartCoroutine(WaitAndPrint1());
        }
    }

    IEnumerator WaitAndPrint1()
    {
        yield return new WaitForSeconds(DestroyTime);
		Destroy(gameObject);
    }
}
