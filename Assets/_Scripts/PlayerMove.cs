using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

	//Jump playerJump;

	public float speed;
	float jumpMaxTime;
	float jumpTime;
	public float jumpPower;
	public float moveHorizontal;
	public float moveVertical;

	public bool isJumping;

	public Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	void Update()
	{
		//moveHorizontal = Input.GetAxis("Horizontal");
		//moveVertical = Input.GetAxis("Vertical");

		//Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical).normalized * Time.deltaTime;

		Vector3 movement = Vector3.zero;
		if (Input.GetKey(KeyCode.W))
		{
			movement += Camera.main.transform.forward.normalized;
		}
		if (Input.GetKey(KeyCode.S))
		{
			movement -= Camera.main.transform.forward.normalized;
		}

		if (Input.GetKey(KeyCode.A))
		{
			movement -= Camera.main.transform.right.normalized;
		}
		if (Input.GetKey(KeyCode.D))
		{
			movement += Camera.main.transform.right.normalized;
		}

		rb.AddForce(movement * speed * Time.deltaTime);

		if (Input.GetButtonDown("Jump") && !isJumping)
		{
			isJumping = true;
			jumpMaxTime = Time.time + 0.1f;
			jumpTime = 0.0f;
		}

		if (Input.GetButton("Jump") && Time.time < jumpMaxTime && isJumping)
		{
			jumpTime += Time.deltaTime;

			rb.velocity = new Vector3(rb.velocity.x, jumpPower, rb.velocity.z);

			if (jumpTime < 0.45f)
			{
				Debug.Log("hoppa");
				if (jumpPower < 4)
				{
					jumpPower = jumpPower * 1f;
				}
			}
			else
			{
				Debug.Log("Else");
				jumpPower *= 0.8f;
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
