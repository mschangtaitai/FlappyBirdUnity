using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FlyScript : MonoBehaviour
{
    public float velocity = 1;
    private Rigidbody2D rb;
    private int score = 0;
    public Text scoreText;
    public GameObject gameOverCanvas;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 1; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Counter")
        {
            score++;
            scoreText.text = score.ToString();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("GameScene");
    }
}
