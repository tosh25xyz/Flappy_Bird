
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    private bool collected = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (collected)
            return;

        if (other.CompareTag("Player") ||
            other.transform.root.CompareTag("Player"))
        {
            collected = true;

            CoinWallet wallet =
                FindObjectOfType<CoinWallet>();

            if (wallet != null)
            {
                wallet.AddCoins(1);
            }
            else
            {
                Debug.LogError(
                    "CoinWallet not found in the scene!"
                );
            }

            Destroy(gameObject);
        }
    }
}
