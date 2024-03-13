using UnityEngine;

public class Player : MonoBehaviour
{
    public float baseSpeed;
    private Rigidbody rigidbodyPlayer;

    void Start()
    {
        rigidbodyPlayer = GetComponent<Rigidbody>();
	}

    void Update()
    {
        float moveHoriz = Input.GetAxis("Horizontal");
        float moveVert = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHoriz, 0.0f, moveVert);
		rigidbodyPlayer.AddForce(movement * baseSpeed);
	}
}
