using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementalTile : ElementZone
{
	public Material earthFloor;
	public Material fireFloor;
	public Material waterFloor;
	public Material windFloor;

	public override void Enter(Element thingThatEntered)
	{
		base.Enter(thingThatEntered);
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
						Debug.Log("EVAPORATE!");
						Destroy(this.gameObject, 3);
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
						// Kanske ska ändra denna till att mark blir till jord istället för att försvinna
						//Debug.Log("EVAPORATE!");
						//Destroy(this.gameObject, 3);
						myElement = Elementals.EARTH;
						MeshRenderer rend = GetComponent<MeshRenderer>();
						rend.material = earthFloor;
						break;
					case Elementals.WIND:
						// Nästa tile blir till eld och får en fartbestraffning
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
						Debug.Log("EVAPORATE!");
						Destroy(this.gameObject, 3);
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
