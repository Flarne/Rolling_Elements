using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//using System;

public class HighScore : StartTimer
{
	public TextMeshProUGUI posList;
	public TextMeshProUGUI nameList;
	public TextMeshProUGUI headerTitle;
	//public TextMeshProUGUI timeInList;
	public TextMeshProUGUI timeText;

	private float myTime;

	public GameObject newRow;
	public GameObject listRow;

	public string[] names;
	public float[] times;

	int numberOfTimesInList = 10;
	private string nameInList = "BZZ";
	public static string thisRaceCourseName;
	private static float myTimer;
	float bestTime;

	void Start()
	{
		timeText.text = timerText.text;
		myTimer = endTime;
		Debug.Log("Test endtime " + endTime);
		times = new float[numberOfTimesInList];
		names = new string[numberOfTimesInList];
		thisRaceCourseName = LevelSelect.raceCourseName;
		headerTitle.text = "BEST TIMES ON RACE COURSE: " + thisRaceCourseName;

		LoadBestTimesList();
	}

	private void LoadBestTimesList()
	{
		for (int i = 0; i < times.Length; i++)
		{
			times[i] = PlayerPrefs.GetFloat("time" + i);

			names[i] = PlayerPrefs.GetString("name" + i);
			Debug.Log("Test mytime " + myTimer);
		}

		DisplayBestTimeList();
	}

	private void DisplayBestTimeList()
	{
		//float myBestTime;
		for (int i = 0; i < times.Length; i++)
		{
			GameObject newRow = Instantiate(listRow, transform);

			newRow.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = (i + 1).ToString();

			//endTime = PlayerPrefs.GetFloat("time", endTime);
			//endTime += times[i];
			//myBestTime = endTime;
			newRow.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = FormatTime(endTime);

			newRow.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = nameInList;
		}
	}

	//public void AddTime(int myNewTime)
	//{
	//	myTime += myNewTime;
	//	timeInList.text = times.ToString();
	//}

	public void Update()
	{
		SaveTime();
		//timeText.text = FormatTime(endTime);
		//if (Input.GetKeyDown(KeyCode.T))
		//{
		//	myTime = Random.Range(1, 100) * 1000;
		//	timeText.text = myTime.ToString();
		//	SaveTime();
		//}
		//if (Input.GetKeyDown(KeyCode.R))
		//{
		//	PlayerPrefs.DeleteAll();
		//	DisplayBestTimeList();
		//}
	}

	private void SaveTime()
	{
		int myPlaceInList = -1;

		for (int i = numberOfTimesInList - 1; i >= 0; i--)
		{
			Debug.Log("Place In List " + times[i] + " endTime " + endTime);
			if (endTime < times[i])
			{
				myPlaceInList = i;

				if (i != numberOfTimesInList - 1)
				{
					times[i + 1] = times[i];
				}
			}
			else
			{
				break;
			}
		}

		if (myPlaceInList != - 1)
		{
			Debug.Log("Place In List ");
			times[myPlaceInList] = myTimer;
			DisplayBestTimeList();

			for (int i = 0; i < times.Length; i ++)
			{
				PlayerPrefs.SetFloat("time" + i, times[i]);
			}
		}
	}

	public void ResetHighscoreList()
	{
		PlayerPrefs.DeleteAll();
		bestTime = 0;
	}

	//private void Awake()
	//{
	//	myTimer = endTime;
	//	thisRaceCourseName = LevelSelect.raceCourseName;
	//	headerTitle.text = "BEST TIMES ON RACE COURSE: " + thisRaceCourseName;



	//	bestTime = PlayerPrefs.GetFloat("time#");

	//	if (bestTime != 0)
	//	{
	//		if (myTimer < bestTime)
	//		{
	//			PlayerPrefs.SetFloat("time9", myTimer);
	//			Debug.Log("Tid " + PlayerPrefs.GetFloat("time9"));
	//		}
	//	}
	//	else
	//	{
	//		PlayerPrefs.SetFloat("time9", myTimer);
	//	}



	//	HighScoreList();
	//}

	//private class HighscoreEntry
	//{
	//	public float timeInList;
	//	public string nameInList;
	//}

	//public void HighScoreList()
	//{
	//	float myBestTime;
	//	for (int i = 0; i < times.Length; i++)
	//	{
	//		GameObject newRow = Instantiate(listRow, transform);

	//		newRow.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = (i + 1).ToString();

	//		bestTime = PlayerPrefs.GetFloat("time" + i);
	//		myBestTime = bestTime;
	//		newRow.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = FormatTime(myBestTime);

	//		newRow.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = nameInList;

	//	}

	//}
}


//highScoreEntry = new List<HighscoreEntry>()
//{
//	new HighscoreEntry{timeInList = 1f, nameInList = "POI"},
//	new HighscoreEntry{timeInList = 2f, nameInList = "BZZ"},
//	new HighscoreEntry{timeInList = 3f, nameInList = "PPK"},
//	new HighscoreEntry{timeInList = 4f, nameInList = "APT"},
//	new HighscoreEntry{timeInList = 5f, nameInList = "ASA"},
//	new HighscoreEntry{timeInList = 6f, nameInList = "LIK"},
//	new HighscoreEntry{timeInList = 7f, nameInList = "MOL"},
//	new HighscoreEntry{timeInList = 8f, nameInList = "CMK"},
//	new HighscoreEntry{timeInList = 9f, nameInList = "LOK"},
//	new HighscoreEntry{timeInList = 10f, nameInList = "ROK"},
//};




//private Transform entryContainer;
//private Transform entryTemplate;

////public TextMeshProUGUI posText;
////public TextMeshProUGUI timeText;
////public TextMeshProUGUI nameText;

//private void Awake()
//{
//	entryContainer = transform.Find("HighScoreEntryContainer");
//	entryTemplate = entryContainer.Find("HighScoreEntryTemplate");

//	entryTemplate.gameObject.SetActive(false);

//	float templateHeight = 30f;
//	for (int i = 0; i < 10; i++)
//	{
//		Transform entryTransform = Instantiate(entryContainer, entryTemplate);
//		RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
//		entryRectTransform.anchoredPosition = new Vector2(0, -templateHeight * i);
//		entryTransform.gameObject.SetActive(true);

//		int rank = i + 1;
//		string rankString;
//		switch (rank)
//		{
//			default:
//				rankString = rank + "TH";
//				break;
//			case 1:
//				rankString = "1ST";
//				break;
//			case 2:
//				rankString = "2ND";
//				break;
//			case 3:
//				rankString = "3RD";
//				break;
//		}

//		entryTransform.Find("posText").GetComponent<TextMeshProUGUI>().text = rankString;

//		int score = Random.Range(0, 10000);

//		entryTransform.Find("timeText").GetComponent<TextMeshProUGUI>().text = score.ToString();

//		string name = "BZZ";
//		entryTransform.Find("nameText").GetComponent<TextMeshProUGUI>().text = name;
//	}
//}
