using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform player;
    public float speed = 3f;

    void Update()
    {
        // follow the player position
        if (player != null)
        {
            transform.position = Vector2.MoveTowards(
                transform.position,
                player.position,
                speed * Time.deltaTime
            );
        }
    }

    // Detect when the enemy touches the player
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // IMPORTANT: Ensure your player GameObject has the "Player" tag assigned in the Inspector
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("¡Enemigo tocó al jugador!");

            // Find the GameController and trigger the game over state
            GameController controller = Object.FindFirstObjectByType<GameController>();
            if (controller != null)
            {
                controller.Perder();
            }
        }
    }
}
