using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public TMP_Text textoContador;
    public TMP_Text textoTiempo;

    public GameObject panelGameOver;
    public GameObject panelVictoria;

    public int objetos = 0;
    public int total = 5;

    public float tiempo = 60f;

    bool terminado = false;

    void Update()
    {
        if (terminado) return;

        tiempo -= Time.deltaTime;
        textoTiempo.text = "Tiempo: " + Mathf.Ceil(tiempo);

        if (tiempo <= 0)
        {
            Perder();
        }
    }

    public void SumarObjeto()
    {
            objetos++;
        textoContador.text = objetos + " / " + total;
    }

    public void Perder()
    {
        terminado = true;
        panelGameOver.SetActive(true);
        Time.timeScale = 0;
    }

    public void Ganar()
    {
        terminado = true;
        panelVictoria.SetActive(true);
        Time.timeScale = 0;
    }

    public void IrAlMenu()
    {
                Time.timeScale = 1f; 
        
        // Loads the menu scene by its exact name
        SceneManager.LoadScene("Menu Principal"); 
    }

    public void ContinuarDespuesFicha()
    {
        if (objetos >= total)
        {
            TriviaManager trivia =
                FindFirstObjectByType<TriviaManager>();

            if (trivia != null)
            {
                trivia.TriggerEndLevelTrivia();
                return;
            }
        }

        Time.timeScale = 1f;
    }


}