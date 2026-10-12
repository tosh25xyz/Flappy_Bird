
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check whether the bird touched the coin
        if (other.CompareTag("Player") ||
            other.transform.root.CompareTag("Player"))
        {
            Debug.Log("Coin Collected!");

            Destroy(gameObject);
        }
    }
}
