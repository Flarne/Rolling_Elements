using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementZone : Element
{
	// Holds Triggerzones Trigger (Player)
	// switch MyElement

	//PlayerMove myMove;

	public float startTimer;
	public float timer;
	public float mySpeed;


	public virtual void Enter(Element thingThatEntered)
	{

	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			Element playerElement = other.gameObject.GetComponent<Element>();
			ElementHandler playerHandler = other.gameObject.GetComponent<ElementHandler>();

			Enter(playerElement);

			switch (playerElement.myElement)
			{
				case Elementals.EARTH:
					if (myElement == Elementals.WATER)
					{
						Debug.Log("Tiles Dissappears in time");
					}
					if (myElement == Elementals.FIRE)
					{
						Debug.Log("Slowing down");
						playerHandler.SlowPlayer();
					}
					if (myElement == Elementals.WIND)
					{
						Debug.Log("SpeedBoost");
						playerHandler.SpeedBoostPlayer();
					}
					break;
				case Elementals.FIRE:
					if (myElement == Elementals.WATER)
					{
						Debug.Log("Du är DÖD!!");
						//Destroy(playerElement.gameObject);
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
						//Debug.Log("EVAPORATE!");
						//Destroy(this.gameObject, 2);
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
						Debug.Log("SpeedBoost");
						playerHandler.JumpBoostPlayer();
					}
					if (myElement == Elementals.WATER)
					{
						Debug.Log("JumpBoost");
					}
					if (myElement == Elementals.EARTH)
					{
						Debug.Log("Slowing Down");
					}
					break;
				case Elementals.REGULAR:
					break;
				default:
					break;
			}
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			Element playerElement = other.gameObject.GetComponent<Element>();
			ElementHandler playerHandler = other.gameObject.GetComponent<ElementHandler>();

			switch (playerElement.myElement)
			{
				case Elementals.EARTH:
					if (myElement == Elementals.WATER)
					{
						Debug.Log("Tiles Dissappears in time");
						//playerHandler.Timer();
					}
					if (myElement == Elementals.FIRE)
					{
						Debug.Log("Back to regular speed");
						playerHandler.SpeedBoostPlayer();
					}
					if (myElement == Elementals.WIND)
					{
						Debug.Log("SpeedBoost");
						playerHandler.SlowPlayer();
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
						playerHandler.JumpResetPlayer();
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
			timer = 0.0f;
		}
	}
}
