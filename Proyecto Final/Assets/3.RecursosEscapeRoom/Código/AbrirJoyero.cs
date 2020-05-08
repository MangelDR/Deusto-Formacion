using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirJoyero : MonoBehaviour
{
    public Animator animatorJoyero;
    public Transform player;
    public string mensajeAbrirJoyero = "Es un joyero, Veré si contiene algo interesante.";
    public ImprimirMensaje imprimirMensaje;
    public GameObject key;

    private void OnMouseDown()
    {
        if (Vector3.Distance(player.transform.position, transform.position) < 2f)
        {
            imprimirMensaje.Imprimir(mensajeAbrirJoyero);
            animatorJoyero.SetTrigger("abrir");
            key.SetActive(true);
            Destroy(this);
        }
    }
}
