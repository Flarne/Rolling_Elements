using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalTime : MonoBehaviour
{

	private void OnTriggerEnter(Collider other)
	{
		Time.timeScale = 0;
		SceneManager.LoadScene("Menu");
	}
}
