using UnityEngine;

public class BoxFunctions : MonoBehaviour
{
    public Rigidbody2D myRigidBody2d;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) 
        {
            myRigidBody2d.velocity = new Vector2(0f, 10f);
        }

		if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
		{
			myRigidBody2d.velocity = new Vector2(0f, -10f);
		}

		if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
		{
			myRigidBody2d.velocity = new Vector2(-10f, 0f);
		}

		if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
		{
			myRigidBody2d.velocity = new Vector2(10f, 0f);
		}

		if (transform.position.x > 9.5f)
		{
			Debug.LogWarning("our cube is out of bounds to the Right side!");
		}

		if (transform.position.x < -9.5f)
		{
			Debug.LogWarning("our cube is out of bounds to the Left side!");
		}

		if (transform.position.y > 5.5f)
		{
			Debug.LogWarning("our cube is out of bounds to the Upper side!");
		}
	}
}
