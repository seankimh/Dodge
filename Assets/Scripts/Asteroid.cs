using UnityEngine;

public class Asteroid : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }

        if (other.CompareTag("Player"))
        {
            FindObjectOfType<GameTimer>().StopTimer();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
