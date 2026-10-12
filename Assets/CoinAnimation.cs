
using UnityEngine;

public class CoinAnimation : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed = 3f;
    public float upDownAmount = 0.15f;
    public float upDownSpeed = 2f;

    private Vector3 startPosition;
    private float randomOffset;

    void Start()
    {
        startPosition = transform.position;
        randomOffset = Random.Range(0f, 6.28f);
    }

    void Update()
    {
        // Move left at the same speed as the pipes
        transform.Translate(
            Vector3.left * moveSpeed * Time.deltaTime,
            Space.World
        );

        // Smooth up-down animation
        float yOffset = Mathf.Sin(
            Time.time * upDownSpeed + randomOffset
        ) * upDownAmount;

        transform.position = new Vector3(
            transform.position.x,
            startPosition.y + yOffset,
            transform.position.z
        );

        // Destroy coin after it leaves the screen
        if (transform.position.x < -12f)
        {
            Destroy(gameObject);
        }
    }
}
