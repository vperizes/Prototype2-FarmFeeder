using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int score = 0; 
    private int lives = 3;

    public bool isGameActive;
    private bool isGamePaused;


    public TextMeshProUGUI scoreText; //recognizes UI element to show score
    public TextMeshProUGUI livesText;

    private GameObject player;
    public GameObject pauseMenu;
    public GameObject gameOverMenu;
    public Button mainMenuButton;

    // Start is called before the first frame update
    void Start()
    {
        isGameActive = true;
        player = GameObject.Find("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isGamePaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }

        scoreText.text = "Score: " + score.ToString();
        livesText.text = "Lives: " + lives.ToString();

    }

    public void GameOver()
    {
        isGameActive = false;
        gameOverMenu.SetActive(true);

    }

    private void PauseGame()
    {
        isGamePaused = true;
        pauseMenu.SetActive(true);
        Time.timeScale = 0f; //pauses everything, sets game time to 0
    }

    private void ResumeGame()
    {
        isGamePaused = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1.0f; //resumes game
    }

    public void ReturntoMainMenu()
    {
        ResumeGame();
        SceneManager.LoadScene("MainMenu");
          
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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
