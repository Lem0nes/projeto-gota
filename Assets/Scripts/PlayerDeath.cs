using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerDeath : MonoBehaviour
{

	private bool hasEntered;

	public GameObject CanvasSeringa;

	public GameObject GameOverMenu;

    private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == ("Enemy") && !hasEntered)
		{
			hasEntered = true;
			Time.timeScale = 0f;
			CanvasSeringa.SetActive(false);
			GameOverMenu.SetActive(true);
		}
	}
}
