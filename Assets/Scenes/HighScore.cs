using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {
    public Text highscoretext;
	// Use this for initialization
	void Start () {
        LoadHighScore();
	}

    private void LoadHighScore()
    {
        var score = PlayerPrefs.GetFloat("score");
        highscoretext.text = score.ToString("F2");
    }

  
}
