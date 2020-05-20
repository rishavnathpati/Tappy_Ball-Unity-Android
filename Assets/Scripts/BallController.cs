﻿using UnityEngine;

public class BallController : MonoBehaviour
{
    public float upForce;
    Rigidbody2D rb;
    bool started,gameOver;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        started = false;
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!started)
        {
            if (Input.GetMouseButtonDown(0))
            {
                started = true;
                rb.isKinematic = false;
            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb.velocity = Vector2.zero;
                rb.AddForce(new Vector2(0, upForce));
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Pipe"))
        {
            gameOver = true;
            LevelUIManager.instance.GameOver();
        }
        if(collision.gameObject.CompareTag("Score Checker") && !gameOver)
        {
            ScoreManager.instance.IncrementScore();
        }
    }

}
