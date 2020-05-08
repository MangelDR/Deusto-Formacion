using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImprimirMensaje : MonoBehaviour
{
    private bool imprimiendo = true;
    public GameObject panelMensaje;
    public Text textoMensaje;
    private string mensajeAImprimir = "No sé cuánto tiempo llevo aquí dentro, debo salir de esta habitación cuanto antes..";
    private int indiceCarater = 0;
    public float tiempoTrasImpresion = 1f;
    private float temporizador = 0f; 

    public void Imprimir (string mensaje)
    {
        indiceCarater = 0;
        imprimiendo = true;
        temporizador = 0f;
        panelMensaje.SetActive(true);
        textoMensaje.text = "";
        mensajeAImprimir = mensaje;
    }

    private void Update()
    {
        if (imprimiendo)
        {
            if (indiceCarater < mensajeAImprimir.Length)
            {
                textoMensaje.text += mensajeAImprimir[indiceCarater++];
            }
            else
            {
                imprimiendo = false;
            }
        }
        else
        {
            temporizador += Time.deltaTime;
            if(temporizador >= tiempoTrasImpresion)
            {
                panelMensaje.SetActive(false);
            }
        }
    }
}
