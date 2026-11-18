
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    [Header("Pickup Audio")]
    public AudioClip diamante;

    [Header("Cultural Information")]
    public string itemName;
    public string regionName;

    [TextArea(3, 6)]
    public string culturalFact;

    public Sprite itemImage;

    private bool collected = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player") || collected)
            return;

        collected = true;

        if (diamante != null && Camera.main != null)
        {
            AudioSource.PlayClipAtPoint(
                diamante,
                Camera.main.transform.position
            );
        }

        GameController controller =
            Object.FindFirstObjectByType<GameController>();

        CulturalInfoManager infoManager =
            Object.FindFirstObjectByType<CulturalInfoManager>();

        if (controller != null)
        {
            controller.SumarObjeto();
        }

        if (infoManager != null)
        {
            infoManager.ShowInfo(this);
        }
        else
        {
            Time.timeScale = 1f;
        }

        Destroy(gameObject);
    }
}
