using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Text;
using System;
using UnityEngine.SceneManagement;

public class DataLoader : MonoBehaviour {

    public string url = "http://www.students.oamk.fi/~t4haje00/HighscoreDBconn.php";

    public Text highScoreText;
    public Text howtoPlay;
    public string[] scores;

    // Use this for initialization
    IEnumerator Start () {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        WWW highscoreData = new WWW(url);
        yield return highscoreData;
        string highscoreDataString = highscoreData.text;
        highScoreText.text = highscoreDataString;
        scores = highscoreDataString.Split(';');
        highScoreText.enabled = false;

        if(sceneName == "GameOverScene")
        {
            highScoreText.enabled = true;
        }
	}

    public void ShowValues()
    {
        if (!highScoreText.enabled)
        {
            highScoreText.enabled = true;
        }
        if (howtoPlay.enabled)
        {
            howtoPlay.enabled = false;
            highScoreText.enabled = true;
        }
    }
}
