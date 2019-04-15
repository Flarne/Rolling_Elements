using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
	public Transform target;
	
	void Start()
	{

	}

	private void OnTriggerEnter(Collider collision)
	{
		collision.transform.parent.position = target.position;
	}
}
