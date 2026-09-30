using UnityEngine;

public class gamemanager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject startMenu;      // Canvas > StartMenu
    public GameObject scoreText;      // Canvas > Text (Legacy)
    public GameObject birdSprite; // FLAPPY BIRD PROJECT er SpriteRenderer
    public GameObject highScore;
    public GameObject background;
    //public GameObject Maincamera;
    void Start()
    {
        Time.timeScale = 0f;          // pipe spawn, bird physics, sob freeze
        startMenu.SetActive(true);
        scoreText.SetActive(false);
        birdSprite.SetActive(false);   // bird lukiye rakho
        highScore.SetActive(false);
       // background.SetActive(false);
    }

    public void StartGame()           // Start button er OnClick-e
    {
        startMenu.SetActive(false);
        scoreText.SetActive(true);
        birdSprite.SetActive(true);
        highScore.SetActive(true);
       // background.SetActive(true);
        //Maincamera.SetActive(true);
        Time.timeScale = 1f;          // game chalu
    }
}
