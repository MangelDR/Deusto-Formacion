using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LlaveInutil : MonoBehaviour
{
    private bool haIntentadoCogerla = false;
    public string primerMensaje = "Parece una llave muy antigua, no creo que sea útil...";
    public string mensajeCogerLlave = "No parece que vaya a ser útil pero...";
    public ImprimirMensaje imprimirMensaje;
    public GameObject player;

    private void OnMouseDown()
    {
        if (!haIntentadoCogerla)
        {
            haIntentadoCogerla = true;
            imprimirMensaje.Imprimir(primerMensaje);
        }
        else
        {
            imprimirMensaje.Imprimir(mensajeCogerLlave);
            player.GetComponent<MovimientoPlayerNavigation>().key = true;
            gameObject.SetActive(false);
        }
    }
}
