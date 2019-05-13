using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WowHighScoreList : MonoBehaviour
{

	public Text scoreText;      //Current score text
	private int score;          //Current score

	public Text highscoreText;  //My holder for the text object
	public string[] names;      //List of our names
	public int[] scores;        //list of our scores
	int numberOfScores = 3;     //amount of places on the list

	// Use this for initialization
	void Start()
	{
		//Create our list depending on how many we want.
		scores = new int[numberOfScores];
		names = new string[numberOfScores];

		LoadHighScores();
	}

	private void LoadHighScores()
	{
		for (int i = 0; i < scores.Length; i++)
		{
			scores[i] = PlayerPrefs.GetInt("score" + i);
			//The name list can be separate (as long as we keep the same order)
			//Names fore the high score have not been implemented after this.
			names[i] = PlayerPrefs.GetString("name" + i);
		}
		DisplayHighScore();
	}

	private void DisplayHighScore()
	{
		//Clear the old printout
		highscoreText.text = "";

		for (int i = 0; i < scores.Length; i++)
		{
			highscoreText.text += scores[i].ToString() + "\n"; //add all scores and \n to create new lines.
		}
	}

	//Add and show the current score on the screen.
	public void AddScore(int amount)
	{
		score += amount;
		scoreText.text = score.ToString();
	}

	public void Update()
	{
		//For easy testing, save our score when we hit P
		if (Input.GetKeyDown(KeyCode.P))
		{
			score = Random.Range(1, 100) * 1000;
			scoreText.text = score.ToString();
			SaveScore();
		}
		if (Input.GetKeyDown(KeyCode.R))
		{
			PlayerPrefs.DeleteAll();
			DisplayHighScore();
		}
	}

	private void SaveScore()
	{
		//set our position in the list to something that we cant select.
		int ourPlacement = -1;

		//checking from the back, are we on the high score list?
		//OBS, reverse order on the loop here.
		for (int i = numberOfScores - 1; i >= 0; i--)
		{
			if (score > scores[i]) //Just reverse > for saving the lowest score possible.
			{
				//Yes we are better then this score.
				ourPlacement = i;

				if (i != numberOfScores - 1) //as long as we are not checking the very last spot.
				{
					//move current score down one step. 
					scores[i + 1] = scores[i];
					//This will make sure there is room for us.
				}
			}
			else
			{
				//We are not better then last score we checked, no need to check any more.
				break;
			}
		}

		//If we are outside the high score, ourPlacement will be -1 and we don't want to do anything
		if (ourPlacement != -1)
		{
			//save our score on our spot.
			scores[ourPlacement] = score;
			DisplayHighScore();

			//Save all the scores to player prefs.
			for (int i = 0; i < scores.Length; i++)
			{
				PlayerPrefs.SetInt("score" + i, scores[i]);
			}
		}
	}
}
