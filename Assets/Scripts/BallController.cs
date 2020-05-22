using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    public float upForce;
    bool started,gameOver;
    public AudioSource tapSound, hitSound,backgroundSound;
    public Sprite sadBall;

    Rigidbody2D rb;
    Image Image;

    // Start is called before the first frame update
    void Start()
    {
        Image = GetComponent<Image>();
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
                //tapSound.Play();
                started = true;
                rb.isKinematic = false;
            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                //tapSound.Play();
                rb.velocity = Vector2.zero;
                rb.AddForce(new Vector2(0, upForce));
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Pipe") || collision.gameObject.CompareTag("floor"))
        {
            this.GetComponent<SpriteRenderer>().sprite = sadBall;
            backgroundSound.Pause();
            hitSound.Play();
            gameOver = true;
            LevelUIManager.instance.GameOver();
        }
        if(collision.gameObject.CompareTag("Score Checker") && !gameOver)
        {
            tapSound.Play();
            ScoreManager.instance.IncrementScore();
        }
    }
}
