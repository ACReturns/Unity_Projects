using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
	private void OnCollisionEnter(Collision collision)
	{
		SceneManager.LoadScene("Game Over");
	}
}
