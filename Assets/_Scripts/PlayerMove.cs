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
		moveHorizontal = Input.GetAxisRaw("Horizontal");
		moveVertical = Input.GetAxisRaw("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical).normalized * Time.deltaTime;

		rb.AddForce(movement * speed);
	}
}
