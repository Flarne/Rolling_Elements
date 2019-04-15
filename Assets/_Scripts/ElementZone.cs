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
						//Debug.Log("Tiles Dissappears in time");
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
					if (myElement == Elementals.EARTH)
					{
						// Får tillbaka ditt originaltillstånd
						// Har inte hunnit med denna heller
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
						playerHandler.SlowPlayer();
					}
					if (myElement == Elementals.WIND)
					{
						Debug.Log("SpeedBoost");
						playerHandler.SpeedBoostPlayer();
					}
					if (myElement == Elementals.FIRE)
					{
						// Får tillbaka ditt originaltillstånd
						// Har inte hunnit med denna heller
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
					if (myElement == Elementals.WATER)
					{
						// Får tillbaka ditt originaltillstånd
						// Har inte hunnit med denna heller
					}
					break;
				case Elementals.WIND:
					if (myElement == Elementals.FIRE)
					{
						Debug.Log("SpeedBoost");
						playerHandler.SpeedBoostPlayer();
					}
					if (myElement == Elementals.WATER)
					{
						Debug.Log("JumpBoost");
						playerHandler.JumpBoostPlayer();
					}
					if (myElement == Elementals.EARTH)
					{
						Debug.Log("Slowing Down");
						playerHandler.SlowPlayer();
					}
					if (myElement == Elementals.WIND)
					{
						// Får tillbaka ditt originaltillstånd
						// Har inte hunnit med denna heller
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
						//Debug.Log("Tiles Dissappears in time");
						//playerHandler.Timer();
					}
					if (myElement == Elementals.FIRE)
					{
						playerHandler.SpeedBoostPlayer();
					}
					if (myElement == Elementals.WIND)
					{
						playerHandler.SlowPlayer();
					}
					break;
				case Elementals.FIRE:
					if (myElement == Elementals.WATER)
					{
						//Debug.Log("Du är DÖD!!");
						//playerElement.Die();
					}
					if (myElement == Elementals.EARTH)
					{
						playerHandler.SpeedBoostPlayer();
					}
					if (myElement == Elementals.WIND)
					{
						playerHandler.SlowPlayer();
					}
					break;
				case Elementals.WATER:
					if (myElement == Elementals.FIRE)
					{
						//Debug.Log("Something Dissapears");
					}
					if (myElement == Elementals.EARTH)
					{
						// Har inte fixat denna ännu
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
						playerHandler.SlowPlayer();
					}
					if (myElement == Elementals.WATER)
					{
						//Debug.Log("Slowing down");
						playerHandler.JumpResetPlayer();
					}
					if (myElement == Elementals.EARTH)
					{
						//Debug.Log("Makes you pass through");
						playerHandler.SpeedBoostPlayer();
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
