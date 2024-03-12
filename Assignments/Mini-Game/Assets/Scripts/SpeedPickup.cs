using UnityEngine;

public class SpeedPickup : MonoBehaviour
{
    [SerializeField] float speedBoost = 10;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		FindObjectOfType<Player>().IncreaseSpeed(speedBoost);
		Destroy(gameObject);
	}
}
