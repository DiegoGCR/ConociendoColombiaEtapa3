using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class UIManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clickSound;

    public void Reiniciar()
    {
        StartCoroutine(ReiniciarConSonido());
    }

    private IEnumerator ReiniciarConSonido()
    {
        if (audioSource != null && clickSound != null)
        {
            audioSource.PlayOneShot(clickSound);
            yield return new WaitForSecondsRealtime(
                clickSound.length
            );
        }

        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

