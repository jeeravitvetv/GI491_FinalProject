using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int lives = 3;
    public GameObject life_1;
    public GameObject life_2;
    public GameObject life_3;
    public GameObject player;
    public GameObject gameOverPanel;
    public bool gameOver;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lives == 2)
        {
            life_1.SetActive(false);
        }
        else if (lives == 1)
        {
            life_2.SetActive(false);
        }
        else if (lives <= 0)
        {
            life_3.SetActive(false);
            Destroy(player.gameObject);
            GameOver();
        }
    }

    public void UpdateLives(int changeInLives)
    {
        lives += changeInLives;
    }

    void GameOver()
    {
        gameOver = true;
        gameOverPanel.SetActive(true);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("SpaceShooter");
    }

    public void Quit()
    {
        SceneManager.LoadScene("Menu");
    }
}
