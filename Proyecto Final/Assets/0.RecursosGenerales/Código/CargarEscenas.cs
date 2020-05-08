using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CargarEscenas : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true; 
    }
    public void MetodoCargarEscena (int numeroDeEscena)
    {
        SceneManager.LoadScene(numeroDeEscena);
    }

    private void VolverAlMenu()
    {
        MetodoCargarEscena(0);
    }

    public void VolverAlMenuRetraso (float retraso)
    {
        Invoke("VolverAlMenu", retraso);
    }

    public void CerrarJuego()
    {
        Debug.Log("Cerrando el juego....");
        Application.Quit();
    }
}
