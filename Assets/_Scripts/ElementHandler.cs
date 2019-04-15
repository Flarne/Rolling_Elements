using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementHandler : PlayerMove
{
	PlayerMove myMove;

	public float mySpeed;
	public float myJump;
	public float startTimer;
	public float timer;

	public void Start()
	{
		myMove = gameObject.GetComponent<PlayerMove>();
		mySpeed = myMove.speed;
		myJump = myMove.jumpPower;
	}

	//public void FixedUpdate()
	//{
	//	SlowPlayer();
	//}

	public void SlowPlayer()
	{
		mySpeed = (mySpeed * 0.5f) * 1.5f;
		print(mySpeed);
		myMove.speed = mySpeed;
	}

	public void SpeedBoostPlayer()
	{
		mySpeed = mySpeed * 2f;
		print(mySpeed);
		myMove.speed = mySpeed;
	}

	public void JumpBoostPlayer()
	{
		myJump = myJump * 2f;
		Debug.Log("Hopp: " + myJump);
		myMove.jumpPower = myJump;
	}

	public void JumpResetPlayer()
	{
		myJump = myJump * 0.5f;
		Debug.Log("Hopp: " + myJump);
		myMove.jumpPower = myJump;
	}
}
