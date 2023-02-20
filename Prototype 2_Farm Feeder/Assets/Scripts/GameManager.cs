using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static int score = 0; //these are static so they can be accessed in other scripts
    public static int lives = 3;

    public bool isGameActive;

    public TextMeshProUGUI scoreText; //recognizes UI element to show score
    public TextMeshProUGUI livesText;

    public TextMeshProUGUI gameOverText;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        isGameActive = true;
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score.ToString();
        livesText.text = "Lives: " + lives.ToString();

    }

    public void GameOver()
    {
        isGameActive = false;
        gameOverText.gameObject.SetActive(true);

    }

    public void AddScore(int num)
    {
        score += num;

    }

    public void AddLives(int num)
    {
        lives += num;
        if (lives <= 0)
        {
            GameOver();
            lives = 0;
            player.SetActive(false);
        }
    }


}
