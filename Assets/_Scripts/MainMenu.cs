using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	private static int myIndex;

	private void Start()
	{
		
	}

	public void PlayElements ()
	{
		//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		SceneManager.LoadScene("StartLevel");
	}

	public void Menu()
	{
		SceneManager.LoadScene("Menu");
	}

	public void TryAgain ()
	{
		myIndex = LevelSelect.indexLevel;
		Debug.Log("MyIndex: " + myIndex);
		if (myIndex == 1)
			SceneManager.LoadScene("EarthLevel");
		else if (myIndex == 2)
			SceneManager.LoadScene("FireLevel");
		else if (myIndex == 3)
			SceneManager.LoadScene("WaterLevel");
		else if (myIndex == 4)
			SceneManager.LoadScene("WindLevel");
		//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
	}

	public void QuitGame ()
	{
		Debug.Log("Quit!");
		Application.Quit();
	}
}
