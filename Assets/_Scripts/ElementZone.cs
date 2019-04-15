using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementZone : Element
{
	// Holds Triggerzones Trigger (Player)
	// switch MyElement

	//PlayerMove myMove;
	Jump myJump;
	ElementHandler myHandler;

	public float startTimer;
	public float timer;
	public float mySpeed;

	private void OnTriggerEnter(Collider other)
	{
		Element playerElement = other.gameObject.GetComponent<Element>();
		//myMove = other.gameObject.GetComponent<PlayerMove>();
		myHandler = gameObject.GetComponent<ElementHandler>();
		//mySpeed = myMove.speed;

		switch (playerElement.myElement)
		{
			case Elementals.EARTH:
				if (myElement == Elementals.WATER)
				{
					Debug.Log("Tiles Dissappears in time");
					Timer();
				}
				if (myElement == Elementals.FIRE)
				{
					Debug.Log("Slowing down");
					myHandler.SlowPlayer();
					//mySpeed = mySpeed * 0.5f;
					//print(mySpeed);
					//myMove.speed = mySpeed;
				}
				if (myElement == Elementals.WIND)
				{
					Debug.Log("SpeedBoost");
				}
				break;
			case Elementals.FIRE:
				if (myElement == Elementals.WATER)
				{
					Debug.Log("Du är DÖD!!");
					playerElement.Die();
				}
				if (myElement == Elementals.EARTH)
				{
					Debug.Log("Slowing down");
				}
				if (myElement == Elementals.WIND)
				{
					Debug.Log("SpeedBoost");
				}
				break;
			case Elementals.WATER:
				if (myElement == Elementals.FIRE)
				{
					Debug.Log("Something Dissapears");
				}
				if (myElement == Elementals.EARTH)
				{
					Debug.Log("Something grows");
				}
				if (myElement == Elementals.WIND)
				{
					Debug.Log("SpeedBoost");
				}
				break;
			case Elementals.WIND:
				if (myElement == Elementals.FIRE)
				{
					Debug.Log("JumpBoost");
				}
				if (myElement == Elementals.WATER)
				{
					Debug.Log("Slowing down");
				}
				if (myElement == Elementals.EARTH)
				{
					Debug.Log("Makes you pass through");
				}
				break;
			case Elementals.REGULAR:
				break;
			default:
				break;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		timer = 0.0f;
	}

	private void Timer()
	{
		timer = Time.time - startTimer;
		print(timer);
		if (timer >= 3)
		{
			Destroy(gameObject);
		}
	}
}
