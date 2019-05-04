using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : PlayerMove
{
	//PlayerMove myMove;

	public Transform target;

	void Start()
	{
		//myMove = GetComponent<PlayerMove>();
	}

	private void OnTriggerEnter(Collider collision)
	{
		collision.transform.parent.position = target.position;
		//resetSpeedHorizontal = myMove.moveHorizontal * 0.0f;
		//resetSpeedVertical = myMove.moveVertical * 0.0f;
		SceneManager.LoadScene("UIGameOver");
	}
}
