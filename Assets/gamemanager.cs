using UnityEngine;

public class gamemanager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject startMenu;      // Canvas > StartMenu
    public GameObject scoreText;      // Canvas > Text (Legacy)
    public GameObject birdSprite; // FLAPPY BIRD PROJECT er SpriteRenderer
    public GameObject highScore;
    public GameObject background;
    public GameObject mapSelectionPanel;
    public GameObject pipe2;
    public GameObject pipe1;
    public GameObject pipe3;
    public GameObject bg1;
    public GameObject bg2;
    public GameObject bg3;
    public GameObject cloud;

    //public GameObject Maincamera;
    void Start()
    {
        Time.timeScale = 0f;          // pipe spawn, bird physics, sob freeze
        //startMenu.SetActive(true);
        scoreText.SetActive(false);
        birdSprite.SetActive(false);   // bird lukiye rakho
        highScore.SetActive(false);
        pipe1.SetActive(false);
        pipe2.SetActive(false);
        bg1.SetActive(false);
        bg2.SetActive(false);
        pipe3.SetActive(false);
        bg3.SetActive(false);
        cloud.SetActive(false);
        // background.SetActive(false);
    }

    public void StartGameMap1()           // Start button er OnClick-e
    {
       
        scoreText.SetActive(true);
        birdSprite.SetActive(true);
        highScore.SetActive(true);
        pipe1.SetActive(true);
        mapSelectionPanel.SetActive(false);
        
        bg1.SetActive(true);
        cloud.SetActive(true);

        Time.timeScale = 1f;          // game chalu
    }
    public void StartGameMap2()           // Start button er OnClick-e
    {
        
        scoreText.SetActive(true);
        birdSprite.SetActive(true);
        highScore.SetActive(true);
        mapSelectionPanel.SetActive(false);
        pipe2.SetActive(true);
        cloud.SetActive(true);

        bg2.SetActive(true);
        
        Time.timeScale = 1f;          // game chalu
    }
    public void StartGameMap3()           // Start button er OnClick-e
    {
        //startMenu.SetActive(false);
        scoreText.SetActive(true);
        birdSprite.SetActive(true);
        highScore.SetActive(true);
        mapSelectionPanel.SetActive(false);
        pipe3.SetActive(true);
        cloud.SetActive(true);

        bg3.SetActive(true);
        // background.SetActive(true);
        //Maincamera.SetActive(true);
        Time.timeScale = 1f;          // game chalu
    }
    public void OpenMapSelection()
    {
        startMenu.SetActive(false);
        mapSelectionPanel.SetActive(true);
    }

    public void BackToStartMenu()
    {
        mapSelectionPanel.SetActive(false);
        startMenu.SetActive(true);
    }
}
