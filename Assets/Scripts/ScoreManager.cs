﻿using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public int HighScore;
    public static ScoreManager instance;

    // Start is called before the first frame update
    private void Awake()
    {
        if (instance == null)
            instance = this;
    }
    void Start()
    {
        score = 0;
        PlayerPrefs.SetInt("Score", 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IncrementScore()
    {
        score++;
    }

    public void StopScore()
    {
        PlayerPrefs.SetInt("Score", score);
        if (PlayerPrefs.HasKey("HighScore"))
        {
            if (score > PlayerPrefs.GetInt("HighScore"))
            {
                PlayerPrefs.SetInt("HighScore", score);
                HighScore = PlayerPrefs.GetInt("HighScore");
                Debug.Log("High Score: "+HighScore);
            }
        }
        else
        {
            PlayerPrefs.SetInt("HighScore", score);
            HighScore = PlayerPrefs.GetInt("HighScore");
            Debug.Log("High Score: " + HighScore);
        }
    }

}
