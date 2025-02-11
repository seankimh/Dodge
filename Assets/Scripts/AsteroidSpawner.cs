using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public float spawnRate = 1.5f;
    public float minSpeed = 3f;
    public float maxSpeed = 6f;
    public float spawnXLimit = 8f;

    private float screenTopY;

    void Start()
    {
        screenTopY = Camera.main.ViewportToWorldPoint(new Vector2(0, 1)).y + 1f;
        InvokeRepeating(nameof(SpawnAsteroid), 1f, spawnRate);
    }

    void SpawnAsteroid()
    {
        float randomX = Random.Range(-spawnXLimit, spawnXLimit);
        Vector2 spawnPosition = new Vector2(randomX, screenTopY);

        GameObject asteroid = Instantiate(asteroidPrefab, spawnPosition, Quaternion.identity);

        Rigidbody2D rb = asteroid.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            float randomSpeed = Random.Range(minSpeed, maxSpeed);
            rb.velocity = new Vector2(0, -randomSpeed);
        }
    }
}
