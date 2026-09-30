using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class logic : MonoBehaviour
{
    public int playerscore;
    public Text score;
    public GameObject gameoverscreen;
    public int highScore;
    public Text highScoreText;

    [ContextMenu("INCREASE SCORE")]

    void Start()
    {
        // Load previously saved high score
        
    }
    public void Addscore(int willadd)
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);

        
        highScoreText.text = "High Score: " + highScore.ToString();
        playerscore+=willadd;
        score.text = playerscore.ToString();
        if (playerscore > highScore)
        {
            highScore = playerscore;
            highScoreText.text = "High Score: " + highScore.ToString();

            // Save it permanently
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
        }
    }
    public void Restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Gameover()
    {
        gameoverscreen.SetActive(true);
    }
}

