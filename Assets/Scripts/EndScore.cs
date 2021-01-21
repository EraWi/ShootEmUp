using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndScore : MonoBehaviour {

    public Text scoreEndText;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        scoreEndText.text = ScoreManager.score.ToString();
	}
}
