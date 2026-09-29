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
    [ContextMenu("INCREASE SCORE")]
    public void Addscore(int willadd)
    {
        playerscore+=willadd;
        score.text = playerscore.ToString();
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

