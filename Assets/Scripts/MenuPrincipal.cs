using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management

public class MenuPrincipal : MonoBehaviour
{
    public void IniciarPartida()
    {
        // Loads the gameplay scene
        SceneManager.LoadScene("Nivel1"); 
    }

    public void SalirDelJuego()
    {
        Debug.Log("Saliendo...");
        Application.Quit(); // Closes the game when built
    }
}
