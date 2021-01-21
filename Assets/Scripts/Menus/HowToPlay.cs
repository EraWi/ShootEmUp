using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HowToPlay : MonoBehaviour {

    public Text howToPlay;
    public Text highScoreText;

    void Start()
    {
        howToPlay.enabled = false;
    }

    public void HowToPlayText()
    {
        if (highScoreText.enabled)
        {
            highScoreText.enabled = false;
        }

        howToPlay.enabled = true;
    }
}
