using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StartTimer : MonoBehaviour
{
	private float startTimer;
	public static float endTime;
	public static float timerUpdate = 0.0f;
	bool started;

	public TextMeshProUGUI timerText;

	void Update()
    {
		if (!started)
		{
			return;
		}
		timerUpdate = Time.time - startTimer;
		//timerText.text = timerUpdate.ToString("0.00");
		timerText.text = FormatTime(timerUpdate);
		endTime = timerUpdate;
	}

	void Timer ()
	{
		startTimer = Time.time;
	}

	private void OnTriggerEnter(Collider other)
	{
		started = true;
		Timer();
	}

	public string FormatTime(float time)
	{
		int intTime = (int)time;
		int minutes = intTime / 60;
		int seconds = intTime % 60;
		float fraction = time * 1000;
		fraction = (fraction % 1000);
		string timeText = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, fraction);
		return timeText;
	}
}
