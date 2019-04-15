using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
	Rigidbody rb;

	float jumpMaxTime;
	float jumpTime;
	public float jumpPower;
	public float playerSpeed;
	public float basePlayerSpeed;

	public bool isJumping;
	public bool grounded;

	void Start()
    {
		rb = GetComponent<Rigidbody>();
    }
	
    void Update()
    {
		if (Input.GetButtonDown("Jump") && !isJumping)
		{
			isJumping = true;
			jumpMaxTime = Time.time + 0.1f;
			jumpTime = 0.0f;
			jumpPower = 0.3f;
		}

		if (Input.GetButton("Jump") && Time.time < jumpMaxTime && isJumping)
		{
			jumpTime += Time.deltaTime;

			//rb.AddForce(transform.up * jumpPower);
			rb.velocity = new Vector3(rb.velocity.x, jumpPower, rb.velocity.z);

			if (jumpTime < 0.45f)
			{
				if (jumpPower < 8)
				{
					jumpPower *= 1.2f;
				}
			}
			else
			{
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

	//public void PlayerJump()
	//{
	//	if (Input.GetButtonDown("Jump"))
	//	{
	//		if (grounded)
	//		{
	//			rb.velocity += transform.TransformDirection(Vector3.up * jumpPower);
	//			playerSpeed = basePlayerSpeed * 1.5f;
	//		}
	//	}
	//}
}
