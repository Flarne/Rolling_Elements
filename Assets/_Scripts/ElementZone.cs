using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementZone : Element
{
	//public BoxCollider playerInArea;
	private bool playerinside;
	Elementals lastCheckedElement;
	Element playerElement;
	public virtual void Enter(Element thingThatEntered)
	{
		
	}

	private void Update()
	{
		if (playerinside)
		{
			if(playerElement.myElement != lastCheckedElement && playerElement.myElement != myElement)
			{
				Debug.Log("Han bytte elment");
				lastCheckedElement = playerElement.myElement;
				ElementHandler playerHandler = playerElement.GetComponent<ElementHandler>();
				// Blir kod som körs
				switch (playerElement.myElement)
				{
					case Elementals.EARTH:
						if (myElement == Elementals.WATER)
						{
							// Mark kommer försvinna
							//Debug.Log("Tiles Dissappears in time");
						}
						if (myElement == Elementals.FIRE)
						{
							// Kulan får en hoppboost

							//Debug.Log("JumpBoost");
							//playerHandler.JumpBoostPlayer();
						}
						if (myElement == Elementals.WIND)
						{
							// Här ska det vara vara en fartbestraffning

							//Debug.Log("SlowSpeed");
							//playerHandler.SlowPlayer();
						}
						if (myElement == Elementals.EARTH)
						{
							//(gameObject.GetComponent(typeof(BoxCollider)) as Collider).isTrigger = false;

							// Här ska man inte kunna ta sig förbi, står i GDD
							// Får tillbaka ditt originaltillstånd
							// Har inte hunnit med denna heller
						}
						//else
						//{
						//	(gameObject.GetComponent(typeof(BoxCollider)) as Collider).isTrigger = true;
						//}
						break;
					case Elementals.FIRE:
						if (myElement == Elementals.WATER)
						{
							// här ska det vara en fartbestraffning

							//Debug.Log("Slwo Down");
							//playerHandler.SlowPlayer();
						}
						if (myElement == Elementals.EARTH)
						{
							// här ska det vara en hoppboost

							//Debug.Log("HoppBoost");
							//playerHandler.JumpBoostPlayer();
						}
						if (myElement == Elementals.WIND)
						{
							// Här ska det vara en mer betydande fartökning

							//Debug.Log("SpeedBoost");
							//playerHandler.HyperSpeedBoostPlayer();
						}
						if (myElement == Elementals.FIRE)
						{
							// Här ska man inte kunna ta sig förbi, står i val GDD
							// Får tillbaka ditt originaltillstånd
							// Har inte hunnit med denna heller
						}
						break;
					case Elementals.WATER:
						if (myElement == Elementals.FIRE)
						{
							// Mark ändras till Jord

							//Debug.Log("Ändra mark till jord");
						}
						if (myElement == Elementals.EARTH)
						{
							// Kulan får en fartbestraffning

							//Debug.Log("Slow down");
							//playerHandler.SlowPlayer();
						}
						if (myElement == Elementals.WIND)
						{
							// Både Fartökning och hoppboost

							//Debug.Log("HoppBoost");
							//playerHandler.SpeedBoostPlayer();
							//playerHandler.JumpBoostPlayer();
						}
						if (myElement == Elementals.WATER)
						{
							// Här ska man inte kunna ta sig förbi, står i val GDD
							// Får tillbaka ditt originaltillstånd
							// Har inte hunnit med denna heller
						}
						break;
					case Elementals.WIND:
						if (myElement == Elementals.FIRE)
						{
							// får en fartbestraffning

							//Debug.Log("Slow down");
							//playerHandler.SlowPlayer();
						}
						if (myElement == Elementals.WATER)
						{
							// Kulan får både Fartökning och hoppboost

							//Debug.Log("JumpBoost");
							//playerHandler.SpeedBoostPlayer();
							//playerHandler.JumpBoostPlayer();
						}
						if (myElement == Elementals.EARTH)
						{
							// Marken försvinner
						}
						if (myElement == Elementals.WIND)
						{
							// Här ska man inte kunna ta sig förbi, står i val GDD
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
			else if (playerElement.myElement == myElement)
			{
				Debug.Log("Försökt byta till samma element");
				
				playerElement.GetComponent<ElementalShift>().Shift(lastCheckedElement);
			}
		}
	}
	private void OnTriggerEnter(Collider other)
	{

		if (other.gameObject.tag == "Player")
		{
			playerinside = true;
			playerElement = other.gameObject.GetComponent<Element>();
			ElementHandler playerHandler = other.gameObject.GetComponent<ElementHandler>();
			lastCheckedElement = playerElement.myElement;
			Enter(playerElement);

			// Beroende på vilket element som kulan har påverkas kulans beteende med markens element
			switch (playerElement.myElement)
			{
				case Elementals.EARTH:
					if (myElement == Elementals.WATER)
					{
						// Mark kommer försvinna
						Debug.Log("Tiles Dissappears in time Earth-Water");
					}
					if (myElement == Elementals.FIRE)
					{
						// Kulan får en hoppboost
						Debug.Log("JumpBoost Earth-Fire:");
						playerHandler.JumpBoostPlayer();
					}
					if (myElement == Elementals.WIND)
					{
						// Här ska det vara vara en fartbestraffning
						Debug.Log("Ändra mark till eld Earth-Wind");
						//playerHandler.SlowPlayer();
					}
					if (myElement == Elementals.EARTH)
					{

						// Här ska man inte kunna ta sig förbi, står i GDD
						// Får tillbaka ditt originaltillstånd
						// Har inte hunnit med denna heller
					}
					break;

				case Elementals.FIRE:
					if (myElement == Elementals.WATER)
					{
						// här ska det vara en fartbestraffning
						Debug.Log("Slwo Down Fire-Water");
						playerHandler.SlowPlayer();
					}
					if (myElement == Elementals.EARTH)
					{
						// här ska det vara en hoppboost
						Debug.Log("HoppBoost Fire-Earth");
						playerHandler.JumpBoostPlayer();
					}
					if (myElement == Elementals.WIND)
					{
						// Här ska det vara en mer betydande fartökning
						Debug.Log("SpeedBoost Fire-Wind");
						playerHandler.SpeedBoostPlayer();
					}
					if (myElement == Elementals.FIRE)
					{
						// Här ska man inte kunna ta sig förbi, står i val GDD
						// Får tillbaka ditt originaltillstånd
						// Har inte hunnit med denna heller
					}
					break;
				case Elementals.WATER:
					if (myElement == Elementals.FIRE)
					{
						// Mark ändras till Jord
						Debug.Log("Ändra mark till jord Water-Fire");
					}
					if (myElement == Elementals.EARTH)
					{
						// Kulan får en fartbestraffning
						Debug.Log("Slow down Water-Earth");
						playerHandler.SlowPlayer();
					}
					if (myElement == Elementals.WIND)
					{
						// Både Fartökning och hoppboost
						Debug.Log("HoppBoost Water-Wind");
						playerHandler.SpeedBoostPlayer();
						playerHandler.JumpBoostPlayer();
					}
					if (myElement == Elementals.WATER)
					{
						// Här ska man inte kunna ta sig förbi, står i val GDD
						// Får tillbaka ditt originaltillstånd
						// Har inte hunnit med denna heller
					}
					break;
				case Elementals.WIND:
					if (myElement == Elementals.FIRE)
					{
						// får en fartbestraffning
						Debug.Log("Slow down Wind-Fire");
						playerHandler.SlowPlayer();
					}
					if (myElement == Elementals.WATER)
					{
						// Kulan får både Fartökning och hoppboost
						Debug.Log("JumpBoost Wind-Water");
						playerHandler.SpeedBoostPlayer();
						playerHandler.JumpBoostPlayer();
					}
					if (myElement == Elementals.EARTH)
					{
						// Marken försvinner
					}
					if (myElement == Elementals.WIND)
					{
						// Här ska man inte kunna ta sig förbi, står i val GDD
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
		//if (playerInArea)
		//{
		//	playerInArea.enabled = true;
		//}
		
		if (other.gameObject.tag == "Player")
		{
			playerinside = false;
			Element playerElement = other.gameObject.GetComponent<Element>();
			ElementHandler playerHandler = other.gameObject.GetComponent<ElementHandler>();

			switch (playerElement.myElement)
			{
				case Elementals.EARTH:
					if (myElement == Elementals.WATER)
					{
						
					}
					if (myElement == Elementals.FIRE)
					{
						playerHandler.JumpResetPlayer();
					}
					if (myElement == Elementals.WIND)
					{
						//playerHandler.SpeedBoostPlayer();
					}
					break;
				case Elementals.FIRE:
					if (myElement == Elementals.WATER)
					{
						playerHandler.SpeedBoostPlayer();
					}
					if (myElement == Elementals.EARTH)
					{
						playerHandler.JumpResetPlayer();
					}
					if (myElement == Elementals.WIND)
					{
						playerHandler.SlowPlayer();
					}
					break;
				case Elementals.WATER:
					if (myElement == Elementals.FIRE)
					{
						
					}
					if (myElement == Elementals.EARTH)
					{
						playerHandler.SpeedBoostPlayer();
					}
					if (myElement == Elementals.WIND)
					{
						playerHandler.SlowPlayer();
						playerHandler.JumpResetPlayer();
					}
					break;
				case Elementals.WIND:
					if (myElement == Elementals.FIRE)
					{
						playerHandler.SpeedBoostPlayer();
					}
					if (myElement == Elementals.WATER)
					{
						playerHandler.SlowPlayer();
						playerHandler.JumpResetPlayer();
					}
					if (myElement == Elementals.EARTH)
					{

					}
					break;
				case Elementals.REGULAR:
					break;
				default:
					break;
			}
		}
	}
}
