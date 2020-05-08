using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerVidas : MonoBehaviour
{
    public Text textoVidas;
    public GameObject bola;

    public float tiempoEntreVidas = 1.5f;

    public int vidas = 3;

    public GameObject spawnerBola;

    private Vector2 velocidadInicial = Vector2.zero;

    public void Awake()
    {
        velocidadInicial = bola.GetComponent<Bola>().velocidadInicio;
    }

    public void RestarVida()
    {
        vidas = vidas - 1;

        if (vidas <= 0)
        {
            Debug.Log("No quedan vidas");
            Derrota();
        }

        else
        {
            Invoke("NuevaVida", tiempoEntreVidas);
            Debug.Log("Vidas restantes: " + vidas);
        }
        textoVidas.text = vidas.ToString();
    }

    public GameObject objetoMenu;
    public GameObject textoDerrota; 

    private void NuevaVida()
    {
        bola.transform.position = spawnerBola.transform.position;
        bola.SetActive(true);
    }

    private void Derrota()
    {
        textoDerrota.SetActive(true);
        objetoMenu.SetActive(true);
        bola.GetComponent<Rigidbody2D>().Sleep();
    }
}
