using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
	public Transform target;
	
	void Start()
	{

	}

	private void OnTriggerEnter(Collider collision)
	{
		//collision.transform.parent.position = target.position;
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
	}
}
