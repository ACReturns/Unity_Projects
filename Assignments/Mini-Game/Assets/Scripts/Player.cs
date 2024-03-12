using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float baseSpeed;
    private Rigidbody rigidbodyPlayer;
    // Start is called before the first frame update
    void Start()
    {
        rigidbodyPlayer = GetComponent<Rigidbody>();

	}

    // Update is called once per frame
    void Update()
    {
        float moveHoriz = Input.GetAxis("Horizontal");
        float moveVert = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHoriz, 0.0f, moveVert);
		rigidbodyPlayer.AddForce(movement * baseSpeed);
	}

	public void IncreaseSpeed(float value)
	{
		baseSpeed += value;
	}
}
