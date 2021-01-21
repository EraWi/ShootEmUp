using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public static int score;
    Text scoreTxt;
	// Use this for initialization
	void Start () {
        scoreTxt = GetComponent<Text>();
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        scoreTxt.text = score.ToString();
	}
}
