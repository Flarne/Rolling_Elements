using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GoalTime : StartTimer
{
	public static int previousLevel;

	private void Update()
	{
		timerText.text = FormatTime(endTime);
	}

	private void OnTriggerEnter(Collider other)
	{
		previousLevel = LevelSelect.indexLevel;

		SceneManager.LoadScene("UIEndRace");
	}
}
