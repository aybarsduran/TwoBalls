using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] private GameObject footballBallPrefab;
    [SerializeField] private GameObject basketballBallPrefab;
    public float spawnInterval = 1f;

    private float timer;

    private void Start()
    {
        // Start spawning balls immediately
        timer = spawnInterval;
    }

    private void Update()
    {
        // Update the timer
        timer -= Time.deltaTime;

        // Check if it's time to spawn a ball
        if (timer <= 0f)
        {
            // Reset the timer
            timer = spawnInterval;

            // Spawn a ball
            SpawnBall();
        }
    }

    private void SpawnBall()
    {
        GameObject selectedBallPrefab = (Random.Range(0, 2) == 0) ? footballBallPrefab : basketballBallPrefab;
        // Instantiate the ball prefab at the spawner's position
        GameObject ball = Instantiate(selectedBallPrefab, transform.position, Quaternion.identity);

        // Set the ball's initial velocity (if needed)
        Rigidbody2D ballRigidbody = ball.GetComponent<Rigidbody2D>();
        if (ballRigidbody != null)
        {
            // Add force or set velocity based on your desired behavior
            // ballRigidbody.AddForce(Vector2.up * initialForce, ForceMode2D.Impulse);
            // ballRigidbody.velocity = Vector2.up * initialSpeed;
        }
    }
}
