using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChange : MonoBehaviour
{

	public Material earth;
	public Material fire;
	public Material water;
	public Material wind;

	MeshRenderer rend;


	private void Start()
	{
		rend = GetComponent<MeshRenderer>();
		if (GetComponent<ElementalShift>())
		{
			GetComponent<ElementalShift>().Shift += ChangeMaterial;
		}
	}

	private void OnDisable()
	{
		if (GetComponent<ElementalShift>())
		{
			GetComponent<ElementalShift>().Shift -= ChangeMaterial;
		}
	}

	public void ChangeMaterial(Element.Elementals elementType)
	{
		switch (elementType)
		{
			case Element.Elementals.EARTH:
				rend.material = earth;
				break;
			case Element.Elementals.FIRE:
				rend.material = fire;
				break;
			case Element.Elementals.WATER:
				rend.material = water;
				break;
			case Element.Elementals.WIND:
				rend.material = wind;
				break;
			case Element.Elementals.REGULAR:
				break;
			default:
				break;
		}
	}






}
