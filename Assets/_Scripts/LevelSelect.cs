using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
	
	public int index;
	public static int indexLevel;

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player" && index == 1)
		{
			SceneManager.LoadScene("EarthLevel");
			indexLevel = 1;
		}
		if (other.gameObject.tag == "Player" && index == 2)
		{
			//SceneManager.LoadScene("FireLevel");
			SceneManager.LoadScene("FireLevel");
			indexLevel = 2;
		}
		if (other.gameObject.tag == "Player" && index == 3)
		{
			//SceneManager.LoadScene("FireLevel");
			SceneManager.LoadScene("StartLevel");
			indexLevel = 3;
		}
		if (other.gameObject.tag == "Player" && index == 4)
		{
			//SceneManager.LoadScene("FireLevel");
			SceneManager.LoadScene("StartLevel");
			indexLevel = 4;
		}
	}
}
