using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementalTile : ElementZone
{
	public Material earthFloor;
	public Material fireFloor;
	public Material waterFloor;
	public Material windFloor;

	public BoxCollider stoper;

	public override void Enter(Element thingThatEntered)
	{
		if (stoper)
		{
			stoper.enabled = false;
			if (thingThatEntered.myElement == myElement)
			{
				stoper.enabled = true;
			}
		}

		base.Enter(thingThatEntered);

		// Här påverkas marken beroende på kulans element
		switch (myElement)
		{
			case Elementals.EARTH:
				switch (thingThatEntered.myElement)
				{
					case Elementals.EARTH:
						break;
					case Elementals.FIRE:
						break;
					case Elementals.WATER:
						break;
					case Elementals.WIND:
						// Här kommer marken försvinna
						//Debug.Log("EVAPORATE!");
						//Destroy(this.gameObject, 1);
						break;
					case Elementals.REGULAR:
						break;
					default:
						break;
				}
				break;
			case Elementals.FIRE:
				switch (thingThatEntered.myElement)
				{
					case Elementals.EARTH:
						break;
					case Elementals.FIRE:
						break;
					case Elementals.WATER:
						// Ändra mark till Earth
						//myElement = Elementals.EARTH;
						//MeshRenderer rend = GetComponent<MeshRenderer>();
						//rend.material = earthFloor;
						break;
					case Elementals.WIND:
						break;
					case Elementals.REGULAR:
						break;
					default:
						break;
				}
				break;
			case Elementals.WATER:
				switch (thingThatEntered.myElement)
				{
					case Elementals.EARTH:
						// Här kommer marken försvinna
						//Debug.Log("EVAPORATE!");
						//Destroy(this.gameObject, 1);
						break;
					case Elementals.FIRE:
						break;
					case Elementals.WATER:
						break;
					case Elementals.WIND:
						break;
					case Elementals.REGULAR:
						break;
					default:
						break;
				}
				break;
			case Elementals.WIND:
				switch (thingThatEntered.myElement)
				{
					case Elementals.EARTH:
						// Ändra mark till fire
						//myElement = Elementals.FIRE;
						//MeshRenderer rend = GetComponent<MeshRenderer>();
						//rend.material = fireFloor;
						break;
					case Elementals.FIRE:
						break;
					case Elementals.WATER:
						break;
					case Elementals.WIND:
						break;
					case Elementals.REGULAR:
						break;
					default:
						break;
				}
				break;
			case Elementals.REGULAR:
				break;
			default:
				break;
		}
	}

}
