using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Element : MonoBehaviour
{
	// Holds everything about what state the element are in
	// element MyElement (earth, fire, water, wind)
	// Exampel: Funktion Kill() 
	// element MyElement(earth, fire, water, wind);
	// Make Functions for different boosts and kills

	public Elementals myElement;

	private void Start()
	{

		if (GetComponent<ElementalShift>())
		{
			GetComponent<ElementalShift>().Shift += ChangeElement;
		}
	}

	private void OnDisable()
	{
		if (GetComponent<ElementalShift>())
		{
			GetComponent<ElementalShift>().Shift -= ChangeElement;
		}
	}

	public enum Elementals
	{
		EARTH,
		FIRE,
		WATER,
		WIND,
		REGULAR,
	}

	public void ChangeElement(Elementals newElement)
	{
		myElement = newElement;
	}

	public void Die()
	{

	}
}
