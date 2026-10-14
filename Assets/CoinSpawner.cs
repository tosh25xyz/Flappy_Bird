
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;

    void Start()
    {
        Debug.Log("COIN SPAWNER STARTED");

        InvokeRepeating(nameof(SpawnCoin), 1f, 2f);
    }

    void SpawnCoin()
    {
        Debug.Log("SPAWNING COIN NOW");

        if (coinPrefab == null)
        {
            Debug.LogError("PLEASE ASSIGN COIN PREFAB!");
            return;
        }

        Vector3 randomPosition = new Vector3(
            Random.Range(-3f, 10f),
            Random.Range(-9f, 10f),
            0f
        );

        Instantiate(
            coinPrefab,
            randomPosition,
            Quaternion.identity
        );
    }
}
