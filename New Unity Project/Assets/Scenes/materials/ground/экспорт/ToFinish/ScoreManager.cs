using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] Text HighScoreText;
  

    public static float score;
    int highscore;
    void Start()
    {
        score = 0;
    }

    void Update()
    {
        highscore = (int)score;
       
        if (PlayerPrefs.GetInt("score") <= highscore)
            PlayerPrefs.SetInt("score", highscore);

        HighScoreText.text = "HighScore: " + PlayerPrefs.GetInt("score").ToString();
    }
}
