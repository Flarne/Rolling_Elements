using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GoalTime : StartTimer
{

	private static float timeHere;
	public static int previousLevel;

	private void Start()
	{
		timeHere = endTime;
	}

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
