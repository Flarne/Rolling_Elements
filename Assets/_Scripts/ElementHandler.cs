using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementHandler : MonoBehaviour
{
	PlayerMove myMove;

	public float mySpeed;

	public void Start()
	{
		myMove = gameObject.GetComponent<PlayerMove>();
		mySpeed = myMove.speed;
	}

	public void FixedUpdate()
	{
		SlowPlayer();
	}

	public void SlowPlayer()
	{
		mySpeed = mySpeed * 0.5f;
		print(mySpeed);
		myMove.speed = mySpeed;
	}
}
