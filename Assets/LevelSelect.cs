using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
	LevelIndex levelIndex;


	public int index;

    // Start is called before the first frame update
    void Start()
    {
		levelIndex = gameObject.GetComponent<LevelIndex>();
		//index = levelIndex.indexLevel;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player" && index == 1)
		{
			// index = levelIndex.indexLevel;
			//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
			SceneManager.LoadScene("EarthLevel");
		}
		if (other.gameObject.tag == "Player" && index == 2)
		{
			// index = levelIndex.indexLevel;
			//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
			//SceneManager.LoadScene("FireLevel");
			SceneManager.LoadScene("StartLevel");
		}
		if (other.gameObject.tag == "Player" && index == 3)
		{
			// index = levelIndex.indexLevel;
			//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
			//SceneManager.LoadScene("FireLevel");
			SceneManager.LoadScene("StartLevel");
		}
		if (other.gameObject.tag == "Player" && index == 4)
		{
			// index = levelIndex.indexLevel;
			//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
			//SceneManager.LoadScene("FireLevel");
			SceneManager.LoadScene("StartLevel");
		}
	}
}
