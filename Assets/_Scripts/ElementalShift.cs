using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementalShift : MonoBehaviour
{

	public delegate void ShiftDelegates(Element.Elementals newElement);
	public ShiftDelegates Shift;

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			if (Shift != null)
			{
				Shift(Element.Elementals.EARTH);
			}
		}

		else if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			if (Shift != null)
			{
				Shift(Element.Elementals.FIRE);
			}
		}

		else if (Input.GetKeyDown(KeyCode.Alpha3))
		{
			if (Shift != null)
			{
				Shift(Element.Elementals.WATER);
			}
		}

		else if (Input.GetKeyDown(KeyCode.Alpha4))
		{
			if (Shift != null)
			{
				Shift(Element.Elementals.WIND);
			}
		}

		//public Material fire;
		//public Material earth;
		//public Material wind;
		//public Material water;

		//public bool clicked;

		//Renderer colorShift = new Renderer();

		//private void Start()
		//{
		//	colorShift = GetComponent<Renderer>();
		//}

		//if (Input.GetKeyDown(KeyCode.Alpha1))
		//{
		//	if (!clicked)
		//	{
		//		colorShift.material = earth;
		//		clicked = true;
		//	}
		//}
		//
		//else if (Input.GetKeyDown(KeyCode.Alpha2))
		//{
		//	if (!clicked)
		//	{
		//		colorShift.material = fire;
		//		clicked = true;
		//	}
		//}
		//
		//else if (Input.GetKeyDown(KeyCode.Alpha3))
		//{
		//	if (!clicked)
		//	{
		//		colorShift.material = water;
		//		clicked = true;
		//	}
		//}
		//
		//else if (Input.GetKeyDown(KeyCode.Alpha4))
		//{
		//	if (!clicked)
		//	{
		//		colorShift.material = wind;
		//		clicked = true;
		//	}
		//}
		//
		//else
		//{
		//	clicked = false;
		//}
	}
}
