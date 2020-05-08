using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ManagerPuntuacion : MonoBehaviour
{
    public int puntuacion = 0;
    public Text textoPuntuacion;

    public void SumarPuntos(int puntosASumar)
    {
        puntuacion = puntuacion + puntosASumar;
        Debug.Log("+" + puntosASumar + "\nPuntuación: " + puntuacion);
        textoPuntuacion.text = puntuacion.ToString();
    }

    public GameObject objetoMenu;
    public GameObject textoVictoria;

    public void Victoria()
    {
        textoVictoria.SetActive(true);
        objetoMenu.SetActive(true);
    }
}
