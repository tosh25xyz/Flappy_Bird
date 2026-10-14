
using UnityEngine;

public class bird : MonoBehaviour
{
    public Rigidbody2D hisRigidbody;
    public float flapstrength;
    public logic mylogic;
    public bool birdalive = true;

    [Header("Bird Animation")]
    public SpriteRenderer spriteRenderer;
    public Sprite[] frames;
    public float frameRate = 0.12f;

    private int currentFrame = 0;
    private float animationTimer = 0f;

    void Start()
    {
        gameObject.name = "FLAPPY BIRD PROJECT";

        mylogic = GameObject.FindGameObjectWithTag("logic")
                            .GetComponent<logic>();

        // Show the first frame immediately
        if (spriteRenderer != null && frames.Length > 0)
        {
            spriteRenderer.sprite = frames[0];
        }
    }

    void Update()
    {
        // Animate the bird continuously
        AnimateBird();

        // Existing movement logic
        if (Input.GetKeyDown(KeyCode.Space) && birdalive)
        {
            hisRigidbody.linearVelocity = Vector2.up * flapstrength;
        }

        // Existing screen boundary check
        Vector3 screenPosition =
            Camera.main.WorldToViewportPoint(transform.position);

        if ((screenPosition.y > 1f || screenPosition.y < 0f)
            && birdalive)
        {
            birdalive = false;
            mylogic.Gameover();
        }
    }

    void AnimateBird()
    {
        if (spriteRenderer == null || frames == null ||
            frames.Length == 0)
        {
            return;
        }

        animationTimer += Time.deltaTime;

        if (animationTimer >= frameRate)
        {
            animationTimer = 0f;

            currentFrame = (currentFrame + 1) % frames.Length;

            spriteRenderer.sprite = frames[currentFrame];
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (birdalive)
        {
            birdalive = false;
            mylogic.Gameover();
        }
    }
}
