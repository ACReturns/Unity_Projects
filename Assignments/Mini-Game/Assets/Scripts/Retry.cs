using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
	private void OnCollisionEnter(Collision collision)
	{
		SceneManager.LoadScene("Level 1");
	}
}
