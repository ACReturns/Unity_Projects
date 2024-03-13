using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public void LoadFirstLevel()
	{
		SceneManager.LoadScene("Level 1");
	}

	private void OnCollisionEnter(Collision collision)
	{
		SceneManager.LoadScene("Main Menu");
	}
}
