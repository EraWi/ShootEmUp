using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LivesManager : MonoBehaviour {

    public static int currentLives;
    public static int currentHealth;
    bool played;
    public Text livesText;
    public Text healthText;

	// Use this for initialization
	void Start () {
        played = false;
        currentLives = 3;
        currentHealth = 3;
    }

    void Update ()
    {
        setLivesText();
        setHealthText();

        if(livesText.text == "GAME OVER" && !played)
        {
            played = true;
        }
	}

    void setLivesText()
    {
        livesText.text = "Lives: " + currentLives.ToString();

        if(currentLives <= 0)
        {
            SceneManager.LoadScene("GameOverScene", LoadSceneMode.Single);
        }
    }
    void setHealthText()
    {
        healthText.text = "Health: " + currentHealth.ToString();
    }


}
