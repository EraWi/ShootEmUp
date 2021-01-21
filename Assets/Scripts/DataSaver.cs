using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DataSaver : MonoBehaviour {

    public InputField input;
    public Text scoreText;

    string url = "http://www.students.oamk.fi/~t4haje00/HighScoreDBsave.php";

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void InserData(string name, string score)
    {
        WWWForm form = new WWWForm();
        form.AddField("namePost", name);
        form.AddField("scorePost", score);

        WWW www = new WWW(url, form);
    }

    public void SaveButton()
    {
        InserData(input.text, scoreText.text);
    }
}
