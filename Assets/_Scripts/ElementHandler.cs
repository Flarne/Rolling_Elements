using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementHandler : MonoBehaviour
{
	PlayerMove myMove;

	public float mySpeed;
	public float myJump;

	public void Start()
	{
		myMove = gameObject.GetComponent<PlayerMove>();
		mySpeed = myMove.speed;
		myJump = myMove.jumpPower;
	}

	public void SlowPlayer()
	{
		mySpeed = mySpeed / 2f;
		Debug.Log("Fart " + mySpeed);
		myMove.speed = mySpeed;
	}

	public void SpeedBoostPlayer()
	{
		mySpeed = mySpeed * 2f;
		Debug.Log("Fart " + mySpeed);
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
		myJump = myJump / 2f;
		Debug.Log("Hopp: " + myJump);
		myMove.jumpPower = myJump;
	}

	public void HyperSpeedBoostPlayer()
	{
		mySpeed = mySpeed * 2.5f;
		Debug.Log("HyperFart " + mySpeed);
		myMove.speed = mySpeed;
	}

	public void HyperSlowPlayer()
	{
		mySpeed = mySpeed / 2.5f;
		Debug.Log("HyperFart " + mySpeed);
		myMove.speed = mySpeed;
	}
}
