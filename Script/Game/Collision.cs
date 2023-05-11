using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Collision : MonoBehaviour
{

	private Rigidbody2D rb;
	private Animator anim;
	
	[SerializeField] AudioSource DeathSoundEffect;
	[SerializeField] AudioSource LevelCompleteSoundEffect;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.tag == "Smrt")
        {
			DeathSoundEffect.Play();
			rb.bodyType = RigidbodyType2D.Static;
			Die();
			StartCoroutine(WaitAndPrint1());
        }
		else if(collision.tag == "FinishLevel")
		{
			StartCoroutine(WaitAndPrint3());
			Player.lastCheckPointPos = new Vector2(0,-2);
			LevelCompleteSoundEffect.Play();
		}
	}

	private void Die()
	{
		anim.SetTrigger("Death");
	}
	private void SpawnPlayer()
	{
		transform.rotation = Quaternion.Euler(0, 0, 0);
		anim.SetTrigger("Spawn");
		StartCoroutine(WaitAndPrint2());
	}


	IEnumerator WaitAndPrint1()
    {
        yield return new WaitForSeconds(1);
		transform.position = Player.lastCheckPointPos;
		SpawnPlayer();
    }

	IEnumerator WaitAndPrint2()
    {
        yield return new WaitForSeconds(0.5f);
		rb.bodyType = RigidbodyType2D.Dynamic;

    }
	IEnumerator WaitAndPrint3()
    {
		yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
    }
}