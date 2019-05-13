using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rows : MonoBehaviour
{
	public bool alive = false;
	public GameObject rowNumber;

	//private void Start()
	//{
	//	rowNumber = GetComponent<GameObject>();
	//}

	public void SetRow ()
	{
		if (alive)
		{
			GetComponent<MeshRenderer>().enabled = true;
		}
		else
		{
			GetComponent<MeshRenderer>().enabled = false;
		}
	}

	public void SetAlive(bool alive)
	{
		this.alive = alive;
		SetRow();
	}
}
