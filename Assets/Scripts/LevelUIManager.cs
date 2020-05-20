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
        PanelUp.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
