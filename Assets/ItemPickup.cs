using UnityEngine;

public class ItemPickup : MonoBehaviour
{

    public AudioClip diamante;
    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object colliding has the "Player" tag
        if (other.CompareTag("Player"))
        {
            Debug.Log("¡Colisión detectada con el Jugador: " + other.gameObject.name + "!");

            AudioSource.PlayClipAtPoint(diamante, Camera.main.transform.position);

            GameController controller = Object.FindFirstObjectByType<GameController>();
            if (controller != null)
            {
                controller.SumarObjeto();
            }

            // Destroy the item only if the player touched it
            Destroy(gameObject);
        }
        else 
        {
            // Log if a non-player object touches the item
            Debug.Log("Algo que NO es el jugador tocó el objeto: " + other.gameObject.name);
        }
    }
}