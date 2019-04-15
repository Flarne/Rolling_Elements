using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementalTile : ElementZone
{
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
						Debug.Log("EVAPORATE!");
						Destroy(this.gameObject, 2);
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
						Debug.Log("EVAPORATE!");
						Destroy(this.gameObject, 2);
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
				break;
			case Elementals.REGULAR:
				break;
			default:
				break;
		}
	}
}
