using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelUIManager : MonoBehaviour
{
    public static LevelUIManager instance;
    public Text scoreText;
    public GameObject PanelUp;
    public Text HighScore;
    public AudioSource clickSound;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = ScoreManager.instance.score.ToString();
    }

    public void GameOver()
    {
        ScoreManager.instance.StopScore();
        PanelUp.SetActive(true);
        HighScore.text = PlayerPrefs.GetInt("HighScore").ToString();
        Debug.Log(ScoreManager.instance.HighScore.ToString());
    }

    public void Restart()
    {
        clickSound.Play();
        SceneManager.LoadScene("Level1");
    }

    public void Menu()
    {
        clickSound.Play();
        SceneManager.LoadScene("Menu");
    }
}
