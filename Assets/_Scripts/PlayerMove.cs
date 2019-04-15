using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	//Jump playerJump;

	public float speed;
	float jumpMaxTime;
	float jumpTime;
	public float jumpPower;
	public float moveHorizontal;
	public float moveVertical;

	public bool isJumping;
	//private bool jumpButtonDown = false;

	public Rigidbody rb;
	
	void Start () {
		rb = GetComponent<Rigidbody>();
	}

	void Update()
	{
		moveHorizontal = Input.GetAxis("Horizontal");
		moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical).normalized * Time.deltaTime;

		rb.AddForce(movement * speed);

		if (Input.GetButtonDown("Jump") && !isJumping)
		{
			isJumping = true;
			jumpMaxTime = Time.time + 0.1f;
			jumpTime = 0.0f;
		}

		if (Input.GetButton("Jump") && Time.time < jumpMaxTime && isJumping)
		{
			jumpTime += Time.deltaTime;

			//rb.AddForce(transform.up * jumpPower);
			rb.velocity = new Vector3(rb.velocity.x, jumpPower, rb.velocity.z);

			if (jumpTime < 0.45f)
			{
				if (jumpPower < 6)
				{
					jumpPower *= 1f;
				}
			}
			else
			{
				jumpPower *= 0.3f;
			}
		}
		if (Input.GetButtonUp("Jump"))
		{
			jumpMaxTime = 0;
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		isJumping = false;
	}
}
