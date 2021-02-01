using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
	public Rigidbody2D player;

	public float Speed = 20f;

    bool moveLeft = false;
    bool moveRight = false;
    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveLeft = true;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveRight = true;
        }
    }

    void FixedUpdate()
	{
        if (moveLeft)
        {
			player.AddForce(Vector2.right * Time.deltaTime * -Speed);
            moveLeft = false;
        }
		if (moveRight)
		{
			player.AddForce(Vector2.right * Time.deltaTime * Speed);
            moveRight = false;
		}


	}
}
